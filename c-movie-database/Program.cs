using System;
using System.Collections.Generic;
using System.Linq;

namespace c_movie_database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");

            //create a list of moview
            List<Movie> movies = new List<Movie>
            {
                new Movie("The Godfather", "Drama"),
                new Movie("The Shawshank Redemption", "Drama"),
                new Movie("Schindler's List", "Drama"),
                new Movie("Raging Bull", "Drama"),
                new Movie("Casablanca", "Drama"),
                new Movie("One Flew Over the Cuckoo's Nest", "Drama"),
                new Movie("Gone with the Wind", "Drama"),
                new Movie("Citizen Kane", "Drama"),
                new Movie("The Wizard of Oz", "Drama"),
                new Movie("The Godfather", "Drama"),
            };

            bool continueLoop = true;

            while(continueLoop)
            {
                Console.WriteLine($"There are {movies.Count} movies in this list");
                Console.WriteLine($"What category are you interested in? (Drama, Comedy, Horror, Scifi, Animated, Musical, Documentary)");

                string category = Console.ReadLine();

                var filteredMovies = movies.Where(movie => movie.Category == category).ToList();

                if (filteredMovies.Count > 0)
                {
                    Console.WriteLine("Movies in Category");
                    foreach (var movie in filteredMovies)
                    {
                        Console.WriteLine(movie.Title);
                    }
                }
                else
                {
                    Console.WriteLine("\nNo movies found for the selected category or invalid category entered.");
                }

                Console.WriteLine("\nWould you like to continue? (y/n)");
                string response = Console.ReadLine();
                if (response != "y")
                {
                    continueLoop = false;
                }
            }
            Console.WriteLine("By Now");

        }
    }
}
