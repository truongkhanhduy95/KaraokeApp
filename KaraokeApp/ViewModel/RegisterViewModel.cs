using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using KaraokeApp.ViewModel;

namespace KaraokeApp
{
    public class RegisterViewModel : ViewModelBase
    {
        private INavigationService navigationService;

        public RegisterViewModel(INavigationService navigationServie)
        {
            this.navigationService = navigationServie;
        }

        /// <summary>
        /// Navigate to LoginActivity
        /// </summary>
        public void AlreadyHasAccount()
        {
            navigationService.NavigateTo(ViewModelLocator.LoginPageKey);
        }

        /// <summary>
        /// Registers the complete.
        /// Navigate to LoginActivity with username
        /// </summary>
        /// <param name="newUserName">New user.</param>
        public void RegisterComplete(string newUserName)
        {
            navigationService.NavigateTo(ViewModelLocator.LoginPageKey, newUserName);
        }
    }
}