using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRaterRepo
{
    class TVShowRepo
    {
        readonly List<TVShow> _tvShows = new List<TVShow>();
        public bool AddMovie(TVShow content)
        {
            int startingCount = _tvShows.Count;

            _tvShows.Add(content);

            bool wasAdded = (_tvShows.Count > startingCount) ? true : false;
            return wasAdded;
        }
    }
}
