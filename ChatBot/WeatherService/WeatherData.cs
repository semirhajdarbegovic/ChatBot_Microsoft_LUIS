using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml;

namespace ChatBot.WeatherService
{
    public class WeatherData
    {
        private const string APIKEY = "";
        private static string CurrentURL;
        private static string jsonText;

        public static WeatherOnDayInfo.RootObject getWeatherData(string cityName)
        {

            CurrentURL = "http://api.openweathermap.org/data/2.5/weather?q="
                         + cityName + "&mode=json&units=metric&APPID=" + APIKEY;

            using (WebClient client = new WebClient())
            {
                jsonText = client.DownloadString(CurrentURL);
            }

            WeatherOnDayInfo.RootObject rootObject = new WeatherOnDayInfo.RootObject();

            rootObject = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherOnDayInfo.RootObject>(jsonText);

            return rootObject;
        }
    }
}