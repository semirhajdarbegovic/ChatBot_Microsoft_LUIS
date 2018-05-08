using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using Newtonsoft.Json;

namespace ChatBot.MusicSearch
{
    [Serializable]
    public class AzureSearchMusicService
    {
        private static readonly string QueryString = $"https://{WebConfigurationManager.AppSettings["SearchName"]}.search.windows.net/indexes/{WebConfigurationManager .AppSettings["IndexName"]}/docs?api-key={WebConfigurationManager.AppSettings["SearchKey"]}&api-version=2016-09-01&";

        public async Task<MusicSearchResult> SearchByName(string name)
        {
            using (var httpClient = new HttpClient())
            {
                string nameQuey = $"{QueryString}search={name}";
                string response = await httpClient.GetStringAsync(nameQuey);
                return JsonConvert.DeserializeObject<MusicSearchResult>(response);
            }
        }

        public async Task<MusicSearchResult> SearchByEra()
        {
            using (var httpClient = new HttpClient())
            {
                string nameQuey = $"{QueryString}";
                string response = await httpClient.GetStringAsync(nameQuey);
                return JsonConvert.DeserializeObject<MusicSearchResult>(response);
            }
        }
    }
}