using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRater
{
    class Movie
    {
        public string MovieId { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string MaturityRating { get; set; }
        public TimeSpan RunTime { get; set; }
        public string Director { get; set; }
        public List<string> LeadActors { get; set; }
        public string Description { get; set; }

        public Movie()
        {

        }

        public Movie(string movieId, string name, double rating, string maturityRating, TimeSpan runTime, string director, List<string> leadActors, string description)
        {
            MovieId = movieId;
            Name = name;
            Rating = rating;
            MaturityRating = maturityRating;
            RunTime = runTime;
            Director = director;
            LeadActors = leadActors;
            Description = description;
        }
    }
}
