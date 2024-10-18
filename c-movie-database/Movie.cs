using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_movie_database
{
    public class Movie
    {
        //build a class with two variables, title and category
        public string Title { get; set; }
        public string Category { get; set; }


        //constructor that accepts two strings and sets the title and category properties
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

    }
}
