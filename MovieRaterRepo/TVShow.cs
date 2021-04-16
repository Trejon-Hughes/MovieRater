using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRaterRepo
{
    class TVShow
    {
        public string SeriesId { get; set; }
        public double Rating { get; set; }
        public string MaturityRating { get; set; }
        public TimeSpan AverageRuntime
        {
            get
            {
                double averageSeconds = Episodes.Average(timeSpan => timeSpan.TotalSeconds);
                TimeSpan average = TimeSpan.FromSeconds(averageSeconds);
                return average;
            }
        }
        public int NumberOfEpisodes
        {
            get
            {
                return Episodes.Count;
            }
        }
        public List<Episode> Episodes { get; set; }
        public string Creator { get; set; }
        public List<String> LeadingActors { get; set; }
        public string Description { get; set; }
    }
}
