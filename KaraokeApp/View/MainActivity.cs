using Android.App;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Views;
using KaraokeApp.ViewModel;
using System;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using Android.Content.PM;
using System.Threading;
using FloatingSearchViews;

using GalaSoft.MvvmLight.Helpers;
using Android.Content;
using Android.Views;
using System.Threading.Tasks;



namespace KaraokeApp
{
    [Activity(Label = "MainActivity", Theme = "@style/Theme.Splash", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : ActivityBase
    {
        //Main ViewModel
        private static MainViewModel Vm = App.Locator.Main;

        //Controls
        FloatingSearchView searchView;
        RecyclerView recycler;
        List<Song> listData;
        ProgressBar progressBarLoading;
        RecyclerView.LayoutManager layoutManager;
        SongAdapter adapterSong;


        //Shared preferences
        ISharedPreferences pref;
        ISharedPreferencesEditor editor;
        string searchHistory;
        const int searchSuggestItem = 5;


        //Binding listSong
        private List<Song> _listData;

        public List<Song> ListData
        {
            get { return _listData; }
            set
            {
                _listData = value;
                if (_listData.Count != 0)
                {
                    if (adapterSong != null)
                    {
                        adapterSong.ListSong = ListData;
                        RunOnUiThread(() =>
                            {
                                adapterSong.NotifyDataSetChanged();
                                HideLoading();
                            });
                    }
                    
                }
            }
        }

        //search keyword
        //default: anh cu di di
        private string searchString = "anh+cu+di+di";

        //back twice in 2seconds
        private const int TIME_DELAY = 2000;
        private static DateTime back_pressed;
        private static int count_pressed = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

         
            AddControls();
            this.SetBinding(() => Vm.ListData, () => ListData);
            //this.SetBinding(() => Vm.ListData)
            //    .WhenSourceChanges(() =>
            //    {
            //        ListData = Vm.ListData;
            //        //....
            //    });
            adapterSong = new SongAdapter(this);
            LoadSongWithThread("anh+cu+di+di");
            
           
            
            recycler.SetAdapter(adapterSong);
          
            
            AddEvents();
        }
        void DisplayLoading()
        {
            progressBarLoading.Visibility = ViewStates.Visible;
        }
        void HideLoading()
        {
            progressBarLoading.Visibility = ViewStates.Gone;
        }
        private  void LoadSongWithThread(string keyword)
        {
            DisplayLoading();
             Vm.GetSongs(keyword);

        }

        private void ShowListSong()
        {
            adapterSong = new SongAdapter(this);
            recycler.SetAdapter(adapterSong);
            HideLoading();
            //reset search
            searchString = "";
        }

        void AddControls()
        {
            searchView = FindViewById<FloatingSearchView>(Resource.Id.floating_search_view);
            recycler = FindViewById<RecyclerView>(Resource.Id.recycler);
            progressBarLoading = FindViewById<ProgressBar>(Resource.Id.loading);
            layoutManager = new LinearLayoutManager(this);
            recycler.SetLayoutManager(layoutManager);


            pref = Application.Context.GetSharedPreferences("History", FileCreationMode.Private);
            editor = pref.Edit();

            //Get the history search
            searchHistory = pref.GetString("search_string", "");

        }


        void AddEvents()
        {
           
            searchView.Focus += (sender, e) =>
            {
                searchView.SetSearchHint("Search...");


                searchView.SwapSuggestions(SearchHelper.GetHistorySearch(searchSuggestItem));

                //searchView.SwapSuggestions(SearchHistoryHelper.GetHistoryAsync(this, 3));

            };

            searchView.QueryChange += (sender, e) =>
            {
                if (e.OldQuery != e.NewQuery)
                {
                    searchString = e.NewQuery;
                }
                else
                    searchString = e.OldQuery;
            };


            searchView.SuggestionClicked += (sender, e) =>
            {
                var historySuggestion = (SearchSuggestion)e.SearchSuggestion;
                searchString = historySuggestion.SongName;

                LoadSongWithThread(searchString);
            };


            searchView.FocusCleared += (sender, e) =>
            {
                if (searchString != "")
                {

                    //Shared Preferences
                    //remove search string if contains
                    searchHistory += searchString + ";";

                    editor.PutString("search_string", searchHistory);
                    editor.Commit();


                    LoadSongWithThread(searchString);
                    searchView.SetSearchHint(searchString);
                }
            };
        }


        /// <summary>
        /// Press back twice to Exit
        /// </summary>
        public override void OnBackPressed()
        {



            if (count_pressed == 0)
            {
                back_pressed = DateTime.Now;
                Toast.MakeText(this, "Press once again to exit!",
                                       ToastLength.Short).Show();
                count_pressed++;
            }
            else
            {
                var time = (DateTime.Now - back_pressed).TotalMilliseconds;
                if (time < TIME_DELAY)
                {
                    base.OnBackPressed();
                }
                else
                {
                    count_pressed = 0;
                }
            }
        }
    }
}
