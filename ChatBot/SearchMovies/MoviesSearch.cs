using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ChatBot.SearchMovies
{

    [Serializable]
    public class MoviesSearch
    {
        private static string api_key = "";

        private string search_attr =
            "https://api.themoviedb.org/3/search/movie?api_key=" + api_key + "&language=en-US&page=1&include_adult=false&";
        private string popular_movies_string = "https://api.themoviedb.org/3/movie/popular?api_key=" + api_key + "&language=en-US&page=1";

        public async Task<Movie> SearchByName(string name)
        {
            using (var httpClient = new HttpClient())
            {
                string nameQuey = $"{search_attr}query={name}";
                string response = await httpClient.GetStringAsync(nameQuey);
                var seriesCollection = JObject.Parse(response)["results"]
                    .ToObject<ObservableCollection<Movie>>();
                Movie movie = new Movie();
                movie = seriesCollection[0];
                return movie;
            }
        }

        public async Task<List<Movie>> GetPopularMovies()
        {
            using (var httpClient = new HttpClient())
            {
                string response = await httpClient.GetStringAsync(popular_movies_string);
                var seriesCollection = JObject.Parse(response)["results"]
                    .ToObject<ObservableCollection<Movie>>();
                List<Movie> popularMovies = new List<Movie>();
                popularMovies = seriesCollection.ToList();
                return popularMovies;
            }
        }
    }
}