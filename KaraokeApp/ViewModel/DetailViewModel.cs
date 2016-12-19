using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using KaraokeApp.ViewModel;

namespace KaraokeApp
{
	public class DetailViewModel:ViewModelBase
	{
		public DetailViewModel()
		{
			
		}

		/// <summary>
		/// Processes the link.
		/// </summary>
		/// <returns>Code of Youtube Link: dn4uH41zxpw</returns>
		/// <param name="url">Url of Youtube Link</param>

		public string ProcessLink(string url)
		{
			var index = url.LastIndexOf('=');
			url = url.Substring(index + 1);
			return url;
		}

	}
}