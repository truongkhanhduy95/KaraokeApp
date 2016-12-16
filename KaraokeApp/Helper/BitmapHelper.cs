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
using Android.Graphics;
using System.Net;
using Android.Support.V4.Util;
using System.Threading;

namespace KaraokeApp.Helper
{
    class BitmapHelper
    {
        private static LruCache m_memoryCache;
        public BitmapHelper()
        {
            

        }
        
        private static Bitmap GetImageBitmapFromUrl(string url)
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
        public static  void LoadImage(Activity activity,string url, ImageView imageView)
        {
            int cacheSize = 8 * 1024 * 1024;
            m_memoryCache = new LruCache(cacheSize);
            new Thread(new ThreadStart(() =>
            {
                Bitmap bitmap=getBitmapFromMemCache(url);
                if (bitmap == null)
                {
                    bitmap=GetImageBitmapFromUrl(url);
                    addBitmapToMemoryCache(url, bitmap);
                }
                activity.RunOnUiThread(() => ShowImage(imageView, bitmap));
            })).Start();
        }
        public static void ShowImage(ImageView imageView,Bitmap bitmap)
        {
            imageView.SetImageBitmap(bitmap);
        }
        public static void addBitmapToMemoryCache(string key, Bitmap bitmap)
        {
            if (getBitmapFromMemCache(key) == null)
            {
                m_memoryCache.Put(key, bitmap);
            }
        }
        public static Bitmap getBitmapFromMemCache(String key)
        {
            return (Bitmap)m_memoryCache.Get(key);
        }

    }
}