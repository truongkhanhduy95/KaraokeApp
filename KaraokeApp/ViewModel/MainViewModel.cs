using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System.Threading;
using System.Threading.Tasks;

namespace KaraokeApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        //navigate
        private INavigationService navigationService;

        //song service
        private ISongService songService;

        private List<Song> _listData;

        public List<Song> ListData
        {
            get { return _listData??(_listData=new List<Song>()); }
            set { 
                _listData = value;
            RaisePropertyChanged();
            }
        }


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
        public void GetSongs(string keyword,int itemCount)
        {
			Task.Run(() => ListData = songService.GetSongs(keyword,itemCount));
            //Task.Factory.StartNew(() => ListData = songService.GetSongs(keyword));
         
        }
    }
}