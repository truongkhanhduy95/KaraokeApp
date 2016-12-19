
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;

namespace KaraokeApp
{
    [Activity(Label = "DetailActivity")]
	public class DetailsActivity : ActivityBase
	{
		private TextView _txvName, _txvSinger, _txvDescription;
		private WebView _wvVideo;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Detail);
			// Create your application here
			FindControl();
		}

		private void FindControl()
		{
			_txvName = FindViewById<TextView>(Resource.Id.txvName);
			_txvSinger = FindViewById<TextView>(Resource.Id.txvSinger);
			_txvDescription = FindViewById<TextView>(Resource.Id.txvDesciption);

			_wvVideo = FindViewById<WebView>(Resource.Id.wvVideo);
			// Config WebView
			WebSettings settings = _wvVideo.Settings;
			settings.JavaScriptEnabled = true;

			_wvVideo.Settings.LoadWithOverviewMode = true;
			_wvVideo.Settings.UseWideViewPort = true;
			_wvVideo.SetWebChromeClient(new WebChromeClient());

			bool result = GetDataFromMain();
			if (!result) 
				Toast.MakeText(this, "Problem", ToastLength.Short);
		}

		private bool GetDataFromMain()
		{
			NavigationService nav = (NavigationService)ServiceLocator.Current.GetInstance<INavigationService>();
			var song = nav.GetAndRemoveParameter<Song>(Intent);

			if (song != null)
			{
				_txvName.Text = song.Name;
				//TODO Singer and Description
				LoadVideo(song.Link);
				return true;
			}
			return false;
		}

		private void LoadVideo(string url)
		{
			url = Vm.ProcessLink(url);	
			_wvVideo.LoadUrl("https://www.youtube.com/embed/" + url);
		}

		DetailViewModel Vm = App.Locator.Detai;
	}
}