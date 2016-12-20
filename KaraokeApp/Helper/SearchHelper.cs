using System;
using System.Collections.Generic;
using Android.App;
using FloatingSearchViews.Suggestions.Models;

namespace KaraokeApp
{
	public static class SearchHelper
	{
		/// <summary>
		/// Gets the history search save from Shared Preferences.
		/// </summary>
		/// <returns>List string search item.</returns>
		/// <param name="count">number of item want to get</param>
		public static List<ISearchSuggestion> GetHistorySearch(int count)
		{
			var pref = Application.Context.GetSharedPreferences("History", Android.Content.FileCreationMode.Private);

			string searchHistory = pref.GetString("search_string", "");
			string[] listSearch = searchHistory.Split(';');

			var suggestionList = new List<ISearchSuggestion>();

			// handle if listSearch.Lengh < count
			// if [i] negative
			int end = listSearch.Length - 2 < 0 ? 0 : listSearch.Length - 2;
			int to  = end - count < 0 ? 0 : end - count;

			for (int i = end ; i >= to ; i--)
            {
                suggestionList.Add(new SearchSuggestion(listSearch[i]));
            }
			return suggestionList;
		}


		/// <summary>
		/// Gets the suggestion of song name
		/// </summary>
		/// <returns>The suggestion.</returns>
		/// <param name="keyword">Keyword.</param>
		/// <param name="count">number of item want to get</param>
		public static List<ISearchSuggestion> GetSuggestion(string keyword, int count)
		{
			var suggestionList = new List<ISearchSuggestion>();
			for (int i = 0; i < count; i++)
			{
				//Get suggestion
			}

			return suggestionList;
		}
	}
}
