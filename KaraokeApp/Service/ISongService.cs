using System;
using System.Collections.Generic;

namespace KaraokeApp
{
    public interface ISongService
    {
		List<Song> GetSongs(string keyword);
        List<Song> GetSongs(string keyword, int itemCount);
    }
}