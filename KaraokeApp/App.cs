using System;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Views;
using KaraokeApp.ViewModel;

namespace KaraokeApp
{
    public static class App
    {
        private static ViewModelLocator locator;

        public static ViewModelLocator Locator
        {
            get
            {
                if (locator == null)
                {
                    DispatcherHelper.Initialize();

                    var nav = new NavigationService();
                    SimpleIoc.Default.Register<INavigationService>(() => nav);

                    nav.Configure(ViewModelLocator.MainPageKey, typeof(MainActivity));
                    nav.Configure(ViewModelLocator.LoginPageKey, typeof(LoginActivity));
                    nav.Configure(ViewModelLocator.RegisterPageKey, typeof(RegisterActivity));
                    nav.Configure(ViewModelLocator.DetailPageKey, typeof(DetailActivity));

                    locator = new ViewModelLocator();
                }
                return locator;
            }
        }
    }
}