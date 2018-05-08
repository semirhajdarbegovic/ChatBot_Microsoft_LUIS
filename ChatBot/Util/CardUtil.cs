using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using ChatBot.GoogleSearch;
using ChatBot.MusicSearch;
using ChatBot.SearchMovies;
using ChatBot.Services;
using ChatBot.WeatherService;
using Microsoft.Bot.Connector;
using Value = ChatBot.MusicSearch.Value;

namespace ChatBot.Util
{
    public class CardUtil
    {
        public static async void showHeroCard(IMessageActivity message, Movie searchResult)
        {
            //Make reply activity and set layout
            Activity reply = ((Activity)message).CreateReply();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;
           
            //Make each Card for each musician
                List<CardImage> cardImages = new List<CardImage>();
                cardImages.Add(new CardImage(url: searchResult.poster_path));
                HeroCard card = new HeroCard()
                {
                    Title = searchResult.Title,
                    Subtitle = "Movie",
                    Text = searchResult.Overview,
                    Images = cardImages
                };
                reply.Attachments.Add(card.ToAttachment());
            

            //make connector and reply message
            ConnectorClient connector = new ConnectorClient(new Uri(reply.ServiceUrl));
            await connector.Conversations.SendToConversationAsync(reply);
        }

        public static async void showHeroCardMovies(IMessageActivity message, List<Movie> movies)
        {
            //Make reply activity and set layout
            Activity reply = ((Activity)message).CreateReply();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            reply.Attachments = new List<Attachment>();

            foreach (Movie movie in movies)
            {
                List<CardImage> cardImages = new List<CardImage>();
                cardImages.Add(new CardImage(url: movie.poster_path));
                HeroCard card = new HeroCard()
                {
                    Title = movie.Title,
                    Subtitle = "Movie",
                    Text = movie.Overview,
                    Images = cardImages,
                    Buttons = new List<CardAction>()
                    {
                        new CardAction()
                        {
                            Title = "More details",
                            Type = ActionTypes.OpenUrl,
                            Value = $"https://www.themoviedb.org/movie/" + movie.id + "-" + movie.Title
                        }
                    }
                };

                reply.Attachments.Add(card.ToAttachment());
            }



            //make connector and reply message
            ConnectorClient connector = new ConnectorClient(new Uri(reply.ServiceUrl));
            await connector.Conversations.SendToConversationAsync(reply);
        }

        public static async void showHeroCardSearch(IMessageActivity message, List<GoogleSearchList> searchList)
        {
            //Make reply activity and set layout
            Activity reply = ((Activity)message).CreateReply();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            reply.Attachments = new List<Attachment>();

            foreach (GoogleSearchList search in searchList)
            {
                List<CardImage> cardImages = new List<CardImage>();
                cardImages.Add(new CardImage(url: search.ImagePath));
                HeroCard card = new HeroCard()
                {
                    Title = search.Title,
                    Subtitle = "Search Result",
                    Text = search.Snippet,
                    Images = cardImages,
                    Buttons = new List<CardAction>()
                    {
                        new CardAction()
                        {
                            Title = "More details",
                            Type = ActionTypes.OpenUrl,
                            Value = search.Link
                        }
                    }
                };

                reply.Attachments.Add(card.ToAttachment());
            }



            //make connector and reply message
            ConnectorClient connector = new ConnectorClient(new Uri(reply.ServiceUrl));
            await connector.Conversations.SendToConversationAsync(reply);
        }

        public static async void showMusicHeroCard(IMessageActivity message, MusicSearchResult searchResult)
        {
            //Make reply activity and set layout
            Activity reply = ((Activity)message).CreateReply();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            //Make each Card for each musician
            foreach (Value musician in searchResult.value)
            {
                List<CardImage> cardImages = new List<CardImage>();
                cardImages.Add(new CardImage(url: musician.imageURL));
                HeroCard card = new HeroCard()
                {
                    Title = musician.Name,
                    Subtitle = $"Era: {musician.Era } | Search Score: {musician.searchscore}",
                    Text = musician.Description,
                    Images = cardImages
                };
                reply.Attachments.Add(card.ToAttachment());
            }

            //make connector and reply message
            ConnectorClient connector = new ConnectorClient(new Uri(reply.ServiceUrl));
            await connector.Conversations.SendToConversationAsync(reply);
        }

        public static async void showWeatherHeroCard(IMessageActivity message, WeatherOnDayInfo.RootObject searchResult)
        {
            //Make reply activity and set layout
            Activity reply = ((Activity)message).CreateReply();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            //Make each Card for each musician
            string imageUrl = "http://openweathermap.org/img/w/" + searchResult.weather[0].icon + ".png";

            StringBuilder str = new StringBuilder();
            str.AppendLine("Temp : " + searchResult.main.temp.ToString() + " C");
            str.AppendLine();
            str.AppendLine("Humidity : " + searchResult.main.humidity.ToString());
            str.AppendLine();
            str.AppendLine("Min Temp : " + searchResult.main.temp_min.ToString() + " C");
            str.AppendLine();
            str.AppendLine("Max Temp : " + searchResult.main.temp_max.ToString() + " C");


            List<CardImage> cardImages = new List<CardImage>();
                cardImages.Add(new CardImage(url: imageUrl));
                HeroCard card = new HeroCard()
                {
                    Title = "Today, " + searchResult.name,
                    Subtitle = searchResult.weather[0].description,
                    Text = str.ToString(),
                    Images = cardImages
                };
                reply.Attachments.Add(card.ToAttachment());
            

            //make connector and reply message
            ConnectorClient connector = new ConnectorClient(new Uri(reply.ServiceUrl));
            await connector.Conversations.SendToConversationAsync(reply);
        }

        public static async void showBingWikiHeroCard(IMessageActivity message, BingSearch searchResult)
        {
            //Make reply activity and set layout
            Activity reply = ((Activity)message).CreateReply();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            HeroCard card = new HeroCard()
            {
                Title = searchResult.webPages.value[0].name,
                Subtitle = "Powered By Bing Search API",
                Text = searchResult.webPages.value[0].snippet,
                Buttons = new List<CardAction>()
                {
                    new CardAction()
                    {
                        Title = "Read More",
                        Type = ActionTypes.OpenUrl,
                        Value = searchResult.webPages.value[0].displayUrl
                    }
                }
            };
            reply.Attachments.Add(card.ToAttachment());


            //make connector and reply message
            ConnectorClient connector = new ConnectorClient(new Uri(reply.ServiceUrl));
            await connector.Conversations.SendToConversationAsync(reply);
        }
    }
}