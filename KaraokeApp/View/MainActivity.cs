using Android.App;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Views;
using KaraokeApp.ViewModel;
using System;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using Android.Content.PM;

namespace KaraokeApp
{
    [Activity(Label = "MainActivity", Theme = "@style/Theme.Splash", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : ActivityBase
    {
        //Main ViewModel
        private MainViewModel Vm = App.Locator.Main;

        //Controls
        RecyclerView recycler;
        List<Song> listData;
        RecyclerView.LayoutManager layoutManager;
        SongAdapter adapterSong;


        //back twice in 2seconds
        private const int TIME_DELAY = 2000;
        private static DateTime back_pressed;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            AddControls();
            InitData();
            AddEvents();
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

            adapterSong = new SongAdapter(listData);
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
            var time = (DateTime.Now - back_pressed).Milliseconds;

            if (time < TIME_DELAY)
            {
                base.OnBackPressed();
            }
            else
            {
                Toast.MakeText(this, "Press once again to exit!",
                               ToastLength.Short).Show();
            }
            back_pressed = DateTime.Now;
        }
    }
}
