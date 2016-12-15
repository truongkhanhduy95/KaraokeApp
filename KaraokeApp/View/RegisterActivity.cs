using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GalaSoft.MvvmLight.Views;

namespace KaraokeApp
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : ActivityBase
    {
        //ViewModel Register
        private RegisterViewModel Vm = App.Locator.Register;

        //Controls
        private EditText edtUsername, edtPassword, edtConfirmPassword;
        private Button btnRegister, btnLinkToLogin;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Register);
            AddControls();
            AddEvents();
        }

        void AddControls()
        {
            edtUsername = FindViewById<EditText>(Resource.Id.txtRegisterName);
            edtPassword = FindViewById<EditText>(Resource.Id.txtRegisterPassword);
            edtConfirmPassword = FindViewById<EditText>(Resource.Id.txtRegisterConfirmPassword);
            btnLinkToLogin = FindViewById<Button>(Resource.Id.btnLinkToLoginScreen);
            btnRegister = FindViewById<Button>(Resource.Id.btnRegister);
        }

        void AddEvents()
        {
            btnLinkToLogin.Click += (sender, e) => NavigateToLogin();
            btnRegister.Click += (sender, e) => ExecuteRegister();
        }

        void NavigateToLogin()
        {
            Vm.AlreadyHasAccount();
        }

        /// <summary>
        /// Execute register user from service
        /// </summary>
        void ExecuteRegister()
        {
            User newUser;
            if (edtPassword.Text != edtConfirmPassword.Text)
            {
                Toast.MakeText(this, "Password invalid", ToastLength.Short).Show();
                edtPassword.Text = "";
                edtConfirmPassword.Text = "";
            }
            else
            {
                newUser = new User(edtUsername.Text, edtPassword.Text);

                //TODO: Execute register user

                //auto navigate to login
                Vm.RegisterComplete(newUser.Username);
            }

        }
    }
}