using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace SongGroupReq4

{

    public class RatingComparer : IComparer<Song>

    {

        int IComparer<Song>.Compare(Song a, Song b)

        {

            return b.Rating.CompareTo(a.Rating);

        }

    }

}