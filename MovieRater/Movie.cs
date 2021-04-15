using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRater
{
    class Movie
    {
        public string movieId { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string MaturityRating { get; set; }
        public TimeSpan RunTime { get; set; }
        public string Director { get; set; }
        public List<string> LeadActors { get; set; }
        public string Description { get; set; }

    }
}
