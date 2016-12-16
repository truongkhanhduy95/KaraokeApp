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
using Android.Support.V7.Widget;
using Android.Graphics;
using System.Net;
using Square.Picasso;

namespace KaraokeApp
{
    public class SongAdapter : RecyclerView.Adapter
    {
        List<Song> list;
        Activity _activity;
        public SongAdapter(Activity activity, List<Song> list)
        {
            this.list = list;
            this._activity = activity;
        }

        public override int ItemCount
        {
            get
            {
                return list.Count;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            SongViewHolder songHolder = holder as SongViewHolder;

            songHolder.txtSongName.Text = list[position].Name;
            songHolder.txtSinger.Text = "Chi dân";
            Picasso.With(_activity).Load(list[position].Image).Into(songHolder.imgSong);
        }
        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                    
                }
            }

            return imageBitmap;
        }
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            LayoutInflater inflater = LayoutInflater.From(parent.Context);
            View v = inflater.Inflate(Resource.Layout.itemSong, parent, false);
            return new SongViewHolder(v);
        }
    }

    public class SongViewHolder : RecyclerView.ViewHolder
    {
        public ImageView imgSong;
        public TextView txtSongName, txtSinger, txtDuration;
        protected Song song;

        public SongViewHolder(View itemView)
            : base(itemView)
        {
            imgSong = itemView.FindViewById<ImageView>(Resource.Id.imgPicture);
            txtSongName = itemView.FindViewById<TextView>(Resource.Id.txtSongName);
            txtSinger = itemView.FindViewById<TextView>(Resource.Id.txtSinger);
            txtDuration = itemView.FindViewById<TextView>(Resource.Id.txtDuration);

            //song=new Song(txtSongName.Text,

            itemView.Click += (sender, e) =>
            {
                Toast.MakeText(itemView.Context, txtSongName.Text + " clicked!", ToastLength.Short).Show();
            };
        }

    }

}