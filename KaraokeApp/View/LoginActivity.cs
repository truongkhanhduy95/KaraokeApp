using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using Android.Content.PM;

namespace KaraokeApp
{
	[Activity(Label = "LoginActivity", MainLauncher = true, Theme = "@style/Theme.Splash", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class LoginActivity : ActivityBase
	{
		//ViewModelLogin
		private LoginViewModel Vm = App.Locator.Login;

		private EditText edtUserName, edtPassword;
		private Button btnLogin, btnRegister;
		private User user;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Login);
			AddControls();
			AddEvents();
			CheckRegister();
		}

		void AddControls()
		{
			edtUserName = FindViewById<EditText>(Resource.Id.edtUsername);
			edtPassword = FindViewById<EditText>(Resource.Id.edtPassword);
			btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
			btnRegister = FindViewById<Button>(Resource.Id.btnLinkToRegister);
		}

		void AddEvents()
		{
			btnLogin.Click += (sender, e) => ExecuteLogin();
			btnRegister.Click += (sender, e) => ExecuteRegister();
		}

		void ExecuteLogin()
		{
			user = new User(edtUserName.Text, edtPassword.Text);
			if (Vm.LoginWithUser(user)) Finish();
			else Toast.MakeText(
					this,
					"Invalid!!",
					ToastLength.Short).Show();
		}

		void ExecuteRegister()
		{
			Vm.Register();
		}

		/// <summary>
		/// Get username from RegisterActivity if register completed
		/// </summary>
		void CheckRegister()
		{
			NavigationService nav = (NavigationService)ServiceLocator.Current.GetInstance<INavigationService>();
			var param = nav.GetAndRemoveParameter<string>(Intent);
			if (param != null)
			{
				edtUserName.Text = param;
				Toast.MakeText(this, "Register completed!", ToastLength.Long).Show();
				/*var progressDialog = ProgressDialog.Show(this, "Please wait...", "Checking account info...", true);
				new Thread(new ThreadStart(delegate
				{
				//LOAD METHOD TO GET ACCOUNT INFO
				RunOnUiThread(() => Toast.MakeText(this, "Toast within progress dialog.", ToastLength.Long).Show());
				//HIDE PROGRESS DIALOG
				RunOnUiThread(() => progressDialog.Hide());
				})).Start();*/
			}
		}
	}
}