using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    internal class SongRepo
    {
        static List<Song> songList = new List<Song>
        {
          new Song("shape of you","ed sheeran","pop",4.8,10000,DateTime.Parse("12-10-2017")),
          new Song("perfect","ed sheeran","pop",4.5,12000,DateTime.Parse("04-05-2016")),
          new Song("steal my girl","one direction","melody",4.9,2000000,DateTime.Parse("16-09-2000")),
          new Song("mercy","shawn mendes","jazz",4.8,214500,DateTime.Parse("04-05-2016"))
       };
        public static List<Song> GetSongs()
        {
            return songList;
        }
    }
}
