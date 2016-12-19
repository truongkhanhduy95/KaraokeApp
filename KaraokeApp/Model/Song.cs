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

namespace KaraokeApp
{
    public class Song
	{
		public string Link
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public string Image
		{
			get;
			set;
		}

		public string Singer
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		public Song()
		{
		}

		public Song(string link, string name, string singer, string description)
		{
			this.Link = link;
			this.Name = name;
			this.Singer = singer;
			this.Description = description;
		}
	}
}
