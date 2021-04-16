using MovieRater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRaterRepo
{
    public class MovieRaterRepository
    {
        public readonly List<Movie> _movie = new List<Movie>();
        public bool AddMovie(Movie content)
        {
            int startingCount = _movie.Count;

            _movie.Add(content);

            bool wasAdded = (_movie.Count > startingCount) ? true : false;
            return wasAdded;
        }
        public bool DeleteMovie(Movie existingMovie)
        {
            bool removeMovie = _movie.Remove(existingMovie);
            return removeMovie;
        }
        public List<Movie> GetMovies()
        {
            return _movie;
        }
    }
}
