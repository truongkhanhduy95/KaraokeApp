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

namespace KaraokeApp
{
    [Activity(Label = "MainActivity", Theme = "@style/Theme.Splash", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : ActivityBase
    {
        //Main ViewModel
        private static MainViewModel Vm = App.Locator.Main;

        //Controls
        RecyclerView recycler;
        List<Song> listData;
        RecyclerView.LayoutManager layoutManager;
        SongAdapter adapterSong;


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
            //InitData();
            LoadSongWithThread();
            //new LoadSong(Vm, adapterSong, recycler).Execute();
            AddEvents();
        }
        private void LoadSongWithThread()
        {

            new Thread(new ThreadStart(() =>
            {
                List<Song> listData1;
                listData1 = new List<Song>();

                listData1 = Vm.GetSongs("Dieu+anh+biet");

                RunOnUiThread(() => ShowListSong(listData1));
            })).Start();
        }
        private void ShowListSong(List<Song> listSong)
        {
            adapterSong = new SongAdapter(this, listSong);
            recycler.SetAdapter(adapterSong);
        }
        void AddControls()
        {
            recycler = FindViewById<RecyclerView>(Resource.Id.recycler);
            layoutManager = new LinearLayoutManager(this);
            recycler.SetLayoutManager(layoutManager);
        }

        void InitData()
        {

            listData = new List<Song>();

            listData = Vm.GetSongs("Dieu+anh+biet");

            adapterSong = new SongAdapter(this, listData);
            recycler.SetAdapter(adapterSong);
        }

        void AddEvents()
        {
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
