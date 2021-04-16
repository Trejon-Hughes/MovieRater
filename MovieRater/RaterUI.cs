using MovieRaterRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRater
{
    class RaterUI
    {
        //Doesn't run yet because of metadata problems
        //Will likely fix itself as we flesh out the rest of the repos and such
        private readonly MovieRaterRepository _movieRepo = new MovieRaterRepository();
        public void Run()
        {
            RunRater();
        }
        private void RunRater()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Entertainment Rating Inc. Please enter the number of the option you would like to select:\n" +
                    "1: View a list of all movies\n" +
                    "2: Add a movie the list\n" +
                    "3: Remove a movie from the list\n" +
                    "4: Exit\n");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllContent();
                        break;
                    case "2":
                        AddMovieContent();
                        break;
                    case "3":
                        RemoveMovieContent();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option\n" +
                            "Press any key to continue....\n");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void ShowAllContent()
        {
            Console.Clear();
            List<Movie> movieList = _movieRepo.GetMovies();
            foreach (Movie content in movieList)
            {
                ShowMovieDetails(content);
            }
            Console.WriteLine("Press any key to return....");
            Console.ReadKey();
        }
        private void ShowMovieDetails(Movie content)
        {
            Console.WriteLine($"Movie Number: {content.MovieId}\n" +
                $"Movie Name: {content.Name}\n" +
                $"Movie Run Time: {content.RunTime}\n" +
                $"Movie Description: {content.Description}\n" +
                $"Directed by: {content.Director}\n" +
                $"Lead Roles Including: {content.LeadActors}\n" +
                $"Maturity Rating: {content.MaturityRating}\n" +
                $"Rating: {content.Rating}");
        }
        private void AddMovieContent()
        {
            Console.Clear();
            Movie content = new Movie();
            Console.WriteLine("Add a movie here.");
            Console.WriteLine("Please enter a movie number:");
            content.MovieId = Console.ReadLine();
            Console.WriteLine("Please enter the name of the movie:");
            content.Name = Console.ReadLine();
            //This timespan may not work, it is more of a placeholder for now.
            Console.WriteLine("Please enter the run time for the movie here:");
            string runTime = Console.ReadLine();
            TimeSpan timeSpan = TimeSpan.Parse(runTime);
            content.RunTime = timeSpan;
            Console.WriteLine("Please enter a brief description of the movie:");
            content.Description = Console.ReadLine();
            Console.WriteLine("Please enter the name of the director(s) here:");
            content.Director = Console.ReadLine();
            //Will update code to include a list for actors later.
            //Console.WriteLine("Please enter the lead actors here:");
            //content.LeadActors = Console.ReadLine();
            //May change maturity rating to a selectable enum later.
            Console.WriteLine("Please enter the maturity rating here:");
            content.MaturityRating = Console.ReadLine();
            Console.WriteLine("Please enter your rating for this movie (out of 5) here:");
            string stringRating = Console.ReadLine();
            double doubleRating = double.Parse(stringRating);
            content.Rating = doubleRating;
            _movieRepo.AddMovie(content);           
        }
        private void RemoveMovieContent()
        {
            Console.Clear();
            Console.WriteLine("Which movie would you like to remove?");
            List<Movie> movieDetails = _movieRepo.GetMovies();
            int count = 0;
            foreach (Movie content in movieDetails)
            {
                count++;
                Console.WriteLine($"{count}. {content.Name}");
            }
            int movieId = int.Parse(Console.ReadLine());
            int movieName = movieId - 1;
            if(movieName >= 0 && movieName < movieDetails.Count)
            {
                Movie expectedMovie = movieDetails[movieName];
                if (_movieRepo.DeleteMovie(expectedMovie))
                {
                    Console.WriteLine($"{expectedMovie.Name} was removed successfully."); ;
                }
                else
                {
                    Console.WriteLine("The expected item was unable to be located and removed.");
                }
            }
        }
    }
}
