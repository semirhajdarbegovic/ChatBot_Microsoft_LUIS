using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatBot.SearchMovies
{
    public class Movie
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string original_title { get; set; }
        public string Overview { get; set; }
        public string release_date { get; set; }

        private string Poster_path;
        public string poster_path // Getter and setter.
        {
            get
            {
                return "http://image.tmdb.org/t/p/w185//" + Poster_path;
            }

            set
            {
                Poster_path = value;
            }
        }
        public string vote_average { get; set; }
    }
}