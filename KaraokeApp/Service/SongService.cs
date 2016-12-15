using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
namespace KaraokeApp
{
    public class SongService:ISongService
    {
        public SongService()
        {
        }
        public List<Song> GetSongs(string keyword)
        {
            var json = "";
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://karaokecontrol.herokuapp.com/" + keyword);
            }
            List<Song> listSong = JsonConvert.DeserializeObject<List<Song>>(json);
            return listSong;
        }
    }
}