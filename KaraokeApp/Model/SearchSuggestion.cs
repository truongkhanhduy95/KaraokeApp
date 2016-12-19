using System;
using System.Collections.Generic;
using Android.OS;
using Android.Widget;
using FloatingSearchViews.Suggestions.Models;

namespace KaraokeApp
{
public class SearchSuggestion : Java.Lang.Object, ISearchSuggestion
	{

		public SearchSuggestion(string songName)
		{
			Song = null;
			SongName = songName;
		}

		public SearchSuggestion(Song song)
		{
			Song = song;
			SongName = song.Name;
		}

		public Song Song { get; private set; }

		public string SongName { get; private set; }

		// ISearchSuggestion interface

		public string GetBody()
		{
			return SongName;
		}

		public void SetBodyText(TextView textView)
		{
		}

		public bool SetLeftIcon(ImageView imageView)
		{
			/*if (IsHistory)
			{
				imageView.SetImageDrawable(imageView.Resources.GetDrawable(Resource.Drawable.ic_history_black_24dp));
				imageView.Alpha = 0.36f;
			}
			else {
				imageView.SetImageDrawable(new ColorDrawable(Song.Color));
			}*/

			return true;
		}

		public IParcelableCreator GetCreator()
		{
			return CREATOR();
		}

		// IParcelable interface

		//[ExportField("CREATOR")]
		public static IParcelableCreator CREATOR()
		{
			return new ColorSuggestionCreator();
		}

		public int DescribeContents()
		{
			return 0;
		}

		public void WriteToParcel(Parcel dest, ParcelableWriteFlags flags)
		{
			dest.WriteString(SongName);
		}

		public class ColorSuggestionCreator : Java.Lang.Object, IParcelableCreator
		{
			public Java.Lang.Object CreateFromParcel(Parcel source)
			{
				return new SearchSuggestion(source.ReadString());
			}

			public Java.Lang.Object[] NewArray(int size)
			{
				return new SearchSuggestion[size];
			}
		}
	}
}
