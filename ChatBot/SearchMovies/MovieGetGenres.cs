using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Linq;

namespace ChatBot.SearchMovies
{
    [Serializable]
    public class MovieGetGenres
    {
        private static string api_key = "8688ba58d43cdda898cda6d3411444ba";

        private string search_attr =
            "https://api.themoviedb.org/3/genre/movie/list?api_key=" + api_key + "&language=en-US&page=1&include_adult=false&";

        public async Task<List<MovieGenres>> GetGenres()
        {
            using (var httpClient = new HttpClient())
            {
                string response = await httpClient.GetStringAsync(search_attr);
                var seriesCollection = JObject.Parse(response)["genres"]
                    .ToObject<ObservableCollection<MovieGenres>>();

                List<MovieGenres> genres = new List<MovieGenres>();
                genres = seriesCollection.ToList();

                //  movie.poster_path = "http://image.tmdb.org/t/p/w185//" + seriesCollection[0].poster_path;
                return genres;
            }

        }
    }
}