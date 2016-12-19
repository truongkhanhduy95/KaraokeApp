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

using Android.Content;



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
		RecyclerView.LayoutManager layoutManager;
		SongAdapter adapterSong;


		//Shared preferences
		ISharedPreferences pref;
		ISharedPreferencesEditor editor;
		string searchHistory;
		const int searchSuggestItem = 5;


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
			LoadSongWithThread();
			AddEvents();
		}
		private void LoadSongWithThread()
		{

			new Thread(new ThreadStart(() =>
			{
				listData = new List<Song>();
				listData = Vm.GetSongs(searchString);

				RunOnUiThread(() => ShowListSong(listData));
			})).Start();
		}

		private void ShowListSong(List<Song> listSong)
		{
			adapterSong = new SongAdapter(this, listSong);
			recycler.SetAdapter(adapterSong);

			//reset search
			searchString = "";
		}

		void AddControls()
		{
			searchView = FindViewById<FloatingSearchView>(Resource.Id.floating_search_view);
			recycler = FindViewById<RecyclerView>(Resource.Id.recycler);
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

				LoadSongWithThread();
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


					LoadSongWithThread();
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
