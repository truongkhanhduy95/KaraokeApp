using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace KaraokeApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        //navigate
        private INavigationService navigationService;

        //song service
        private ISongService songService;


        public MainViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            this.songService = new SongService();
        }

        public void NavigateToDetail(Song song)
        {
            //TODO: Check song is valid
            if (song != null)
            {
                navigationService.NavigateTo(ViewModelLocator.DetailPageKey, song);
            }
        }

        /// <summary>
        /// Get list songs form API
        /// </summary>
        /// <returns>The songs.</returns>
        public List<Song> GetSongs(string keyword)
        {
            return songService.GetSongs(keyword);
        }
    }
}