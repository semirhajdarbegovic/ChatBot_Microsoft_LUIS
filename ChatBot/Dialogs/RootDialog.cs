using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using ChatBot.BingSearchApi;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using ChatBot.Controllers;
using ChatBot.GoogleSearch;
using ChatBot.MusicSearch;
using ChatBot.QnABot;
using ChatBot.SearchMovies;
using ChatBot.Services;
using ChatBot.Util;
using ChatBot.WeatherService;
using LuisBot;
using Microsoft.Bot.Builder.FormFlow;

namespace ChatBot.Dialogs
{
    [LuisModel("da9ed4ed-006f-4a92-96cb-7f5935eb2598", "0ad4d7fa118f48849f5521b9f40adda0")]
    [Serializable]
    public class RootDialog : LuisDialog<object>
    {

        public enum MovieChoice
        {
            SearchMovie,
            PopularMovie
        }
        public enum UserChoice
        {
            SearchMovie,
            PopularMovie,
            SearchWiki,
            Weather,
            Game,
            Train
        }

        [LuisIntent("Greetigns")]
        public async Task Greetigns(IDialogContext context, IAwaitable<IMessageActivity> message, LuisResult result)
        {
            QureyController qc = new QureyController();

            if (result.TopScoringIntent.Score < 0.4)
            {
                string ans = "";
                ans = qc.GetTrainedAnswer(result.Query);

                qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                

                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }
            else
            {

                string[] listAns1 =
                    {"Well hello there, how are you today?", "Hello, how are you?", "Hellloooo... What's up?"};
                string[] listAns2 =
                    {"I'm relaxing, what about you?", "Nothing much, what about you?", "Just chillin... :) "};
                string[] listAns3 =
                {
                    "I'm fine thank you, what about you?", "I'm doing great", "Great, what about you?",
                    "Fine, what about you :)"
                };
                string ans = "";
                Random rand = new Random();
                bool found = false;
                string[] matching_words1 = {"hello", "yo", "hi", "helo", "Greetings"};
                string[] matching_words2 = {"what", "doing"};
                string[] matching_words3 = {"how"};
                if (FindMatchingString.findMatchingString(result.Query, matching_words1))
                {
                    ans = listAns1[rand.Next(0, listAns1.Length)];
                    found = true;
                }
                else if (FindMatchingString.findMatchingString(result.Query, matching_words2))
                {
                    ans = listAns2[rand.Next(0, listAns2.Length)];
                    found = true;
                }
                else if (FindMatchingString.findMatchingString(result.Query, matching_words3))
                {
                    ans = listAns3[rand.Next(0, listAns3.Length)];
                    found = true;
                }
                else
                {
                    ans = qc.GetTrainedAnswer(result.Query);
                    if (ans.Length > 0)
                    {
                        found = true;
                    }
                }
                if (!found)
                    ans = "Greetins to you :)";
                qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }
        }

        [LuisIntent("Advice")]
        public async Task Advice(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            QureyController qc = new QureyController();
            string ans = qc.GetAnswer(result.Query, "Advice", result.TopScoringIntent.Score.ToString(), "0");
            await context.PostAsync("Here are my thoughts for you : ");
            await context.PostAsync(ans);
            context.Wait(MessageReceived);
        }


        [LuisIntent("UserAnswers")]
        public async Task UserAnswers(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            QureyController qc = new QureyController();
            string ans = "";

            if (result.TopScoringIntent.Score < 0.4)
            {
                ans = qc.GetTrainedAnswer(result.Query);
            }

            if (ans == "" || ans == "Hmmm ...")
            {
                string[] listAns = { "That's great.", "Excelent", "I'm glad to hear that." };
                 Random rand = new Random();
                 ans = listAns[rand.Next(0, listAns.Length)];
            }

            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");
            qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
            await context.PostAsync(ans);
            context.Wait(MessageReceived);
        }

        [LuisIntent("Movies")]
        public async Task Movies(IDialogContext context, LuisResult result)
        {
            QureyController qc = new QureyController();
            string ans = "";
            bool savedData = false;
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");

            if (result.TopScoringIntent.Score < 0.4)
            {
                ans = qc.GetTrainedAnswer(result.Query);
                savedData = true;
            }

            if (ans == "" || ans == "Hmmm ...")
            {
                ans = qc.GetAnswer(result.Query, "Movies", result.TopScoringIntent.Score.ToString(), "0");
                savedData = true;
            }

            if (ans == "")
            {
                var options = new MovieChoice[] { MovieChoice.PopularMovie, MovieChoice.SearchMovie };
                var descriptions = new string[] { "List Popular Movies", "Search for movie" };
                PromptDialog.Choice<MovieChoice>(context, ResumeAfterMovieChoiceSelection,
                    options, "What would you like to choose about movies?", descriptions: descriptions);

            }

            if (savedData)
            {
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                savedData = false;
                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }

        }

        private async Task ResumeAfterMovieChoiceSelection(IDialogContext context, IAwaitable<MovieChoice> result)
        {
            var selection = await result;
            if (selection == MovieChoice.PopularMovie)
            {
                context.Call(new PopularMoviesDialog(), this.ResumeAfterOptionDialog);
            }
            else
            {
                context.Call(new SearchMovieDialog(), this.ResumeAfterOptionDialog);
            }
        }

        public virtual async Task ChildDialogComplete(IDialogContext context, IAwaitable<object> response)
        {
            await context.PostAsync("Thanks for using me as your bot.");
            context.Done(this);
        }

        private async Task ResumeAfterOptionDialog(IDialogContext context, IAwaitable<object> result)
        {
            try
            {
                var message = await result;
                if (message != null)
                {
                    context.Done<object>(null);
                }
            }
            catch (Exception ex)
            {
                await context.PostAsync($"Failed with message: {ex.Message}");
            }
            finally
            {
                context.Done<object>(null);
            }
        }


        [LuisIntent("MovieSearch")]
        public async Task MovieSearch(IDialogContext context, LuisResult result_luis)
        {
            QureyController qc = new QureyController();
            string ans = "";
            qc.PostQuestionOne(result_luis.Query, result_luis.TopScoringIntent.Intent, result_luis.TopScoringIntent.Score.ToString(), "0");
            if (result_luis.TopScoringIntent.Score < 0.4)
            {
                
                ans = qc.GetTrainedAnswer(result_luis.Query);
                qc.PostAnswerOne(ans, result_luis.TopScoringIntent.Intent);
                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }
            else
            {
                string entity = "";

                if (result_luis.Entities.Count > 0)
                {
                    entity = result_luis.Entities[0].Entity;
                }

                if (entity == "")
                {
                    entity = "Star Wars: The Last Jedi";
                    await context.PostAsync("Here is a movie which i found : ");
                }
                try
                {
                    MoviesSearch search = new MoviesSearch();
                    Movie movieResult = await search.SearchByName(entity);
                    
                    if (movieResult.id != 0)
                    {
                        CardUtil.showHeroCard((IMessageActivity)context.Activity, movieResult);
                        ans = movieResult.Title;
                    }
                    else
                    {
                        await context.PostAsync($"I couldn't find a movie :0");
                    }

                }
                catch (Exception e)
                {
                    Debug.WriteLine($"Error when filtering by genre: {e}");
                }
                
                qc.PostAnswerOne(ans, result_luis.TopScoringIntent.Intent);
                context.Done<object>(null);
            }

        }

        [LuisIntent("PopularMovies")]
        public async Task PopularMovies(IDialogContext context, LuisResult result_luis)
        {
            QureyController qc = new QureyController();
            qc.PostQuestionOne(result_luis.Query, result_luis.TopScoringIntent.Intent, result_luis.TopScoringIntent.Score.ToString(), "0");

            if (result_luis.TopScoringIntent.Score < 0.4)
            {
                string ans = "";
                ans = qc.GetTrainedAnswer(result_luis.Query);
                qc.PostAnswerOne(ans, result_luis.TopScoringIntent.Intent);
                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }
            else
            {
                // List of popular movies 
                try
                {
                    MoviesSearch search = new MoviesSearch();
                    List<Movie> movieResult = await search.GetPopularMovies();
                    if (movieResult.Count != 0)
                    {
                        CardUtil.showHeroCardMovies((IMessageActivity)context.Activity, movieResult);
                        qc.PostAnswer(result_luis.Query, movieResult[0].Title, "PopularMovies", "0.75", "0.75");
                    }
                    else
                    {
                        await context.PostAsync($"I couldn't find a movie :0");
                        qc.PostAnswer(result_luis.Query, "I couldn\'t find a movie", "PopularMovies", "0.75", "0.75");
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"Error when filtering by popular movies: {e}");
                }
                context.Done<object>(null);
            }
        }


        [LuisIntent("Help")]
        public async Task Help(IDialogContext context, LuisResult result)
        {
            QureyController qc = new QureyController();

            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");
            
            if (result.TopScoringIntent.Score < 0.4)
            {
                string ans = "";
                ans = qc.GetTrainedAnswer(result.Query);
               
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);

                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }
            else
            {
                var options = new UserChoice[]
                {
                    UserChoice.SearchWiki, UserChoice.Weather, UserChoice.PopularMovie, UserChoice.SearchMovie,
                    UserChoice.Game, UserChoice.Train
                };
                var descriptions = new string[]
                {
                    "Search Wikipedia", "Get Weather Info", "Popular Movies", "Search for movie", "Play Game",
                    "Train Me"
                };
                PromptDialog.Choice<UserChoice>(context, ResumeAfterDialogChoiceSelection,
                    options, "You asked for help, well here are some of main topics you can find here...",
                    descriptions: descriptions);
            }
        }

        private async Task ResumeAfterDialogChoiceSelection(IDialogContext context, IAwaitable<UserChoice> result)
        {
            var selection = await result;
            if (selection == UserChoice.PopularMovie)
            {
                context.Call(new PopularMoviesDialog(), this.ResumeAfterOptionDialog);
            }
            else if (selection == UserChoice.SearchMovie)
            {
                context.Call(new SearchMovieDialog(), this.ResumeAfterOptionDialog);
            }
            else if (selection == UserChoice.SearchWiki)
            {
                context.Call(new BingWikiSearchDialog(), this.ResumeAfterOptionDialog);
            }
            else if (selection == UserChoice.Weather)
            {
                context.Call(new WeatherDialog(), this.ResumeAfterOptionDialog);
            }
            else if (selection == UserChoice.Train)
            {
                context.Call(new TrainDialog(), this.ResumeAfterOptionDialog);
            }
            else
            {
                await context.PostAsync("To play a game, answer question using numbers (1/2). To quit or exit game, just type 'stop' ");
                context.Call(new GameDialog(), this.ResumeGameAfterOptionDialog);
            }
        }

        [LuisIntent("GoogleSearch")]
        public async Task GoogleSearch(IDialogContext context, LuisResult result_luis)
        {
            QureyController qc = new QureyController();
            string ans = "";
            qc.PostQuestionOne(result_luis.Query, result_luis.TopScoringIntent.Intent, result_luis.TopScoringIntent.Score.ToString(), "0");
            try
            {
                List<GoogleSearchList> searchResult = GoogleSearchApi.getSearchResult(result_luis.Query);
                if (searchResult.Count != 0)
                {
                    await context.PostAsync($"Here is what i found");
                    await context.PostAsync($"List of search results : ");
                    CardUtil.showHeroCardSearch((IMessageActivity)context.Activity, searchResult);
                    ans = searchResult[0].Link;
                }
                else
                {
                    ans = $"I couldn't find a desired search :(";
                    await context.PostAsync(ans);
                }
            }
            catch (Exception e)
            {
                ans = $"Sorry, I'm currently unable to do a specific search, please try again later.";
                await context.PostAsync(ans);
                Debug.WriteLine($"Error when filtering by popular movies: {e}");
            }
            if (ans == "")
                ans = "Google_search_result";
            qc.PostAnswerOne(ans, result_luis.TopScoringIntent.Intent);
            context.Done<object>(null);

        }

        [LuisIntent("Yes")]
        public async Task Yes(IDialogContext context, LuisResult result)
        {
            QureyController qc = new QureyController();
            string ans = "";
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");
            
            if (result.TopScoringIntent.Score < 0.3)
            {
                ans = qc.GetTrainedAnswer(result.Query);
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }
            else
            {
                string[] matching_words = {"everything"};
                string[] listAns =
                    {"Yes is what i like to hear.", "That's the spirit.", "Yes is always the right answer."};

                if (FindMatchingString.findMatchingString(result.Query, matching_words))
                {
                    listAns = new string[] {"We should talk more often", "Ohh.. ok."};
                }

                Random random = new Random();
                int rand = random.Next(0, listAns.Length);
                ans = listAns[rand];

                await context.PostAsync(ans);
                context.Wait(MessageReceived);
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
            }
        }

        [LuisIntent("No")]
        public async Task No(IDialogContext context, LuisResult result)
        {
            QureyController qc = new QureyController();
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");

            if (result.TopScoringIntent.Score < 0.3)
            {
                string ans = "";
                ans = qc.GetTrainedAnswer(result.Query);
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }
            else
            {
                string[] matching_words = {"nothing"};
                string ans = "";
                string[] listAns = {"Oh ok..", "Well..ok.", "Ok, human.", "I did not expect that."};
                if (FindMatchingString.findMatchingString(result.Query, matching_words))
                {
                    listAns = new string[]
                    {
                        "Let yourself experience how nothing feels.", "Often under nothingness is great depth",
                        "I invite you to rest in nothingness"
                    };
                }
                Random random = new Random();
                int rand = random.Next(0, listAns.Length);
                ans = listAns[rand];
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }
        }

        [LuisIntent("Joke")]
        public async Task Joke(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            QureyController qc = new QureyController();
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");
            if (result.TopScoringIntent.Score < 0.4)
            {
                string ans = "";
                ans = qc.GetTrainedAnswer(result.Query);
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }
            else
            {
                await context.PostAsync("Here is one joke... ");
                await context.PostAsync(qc.GetAnswer(result.Query, "Joke", result.TopScoringIntent.Score.ToString(), "0"));
                context.Wait(MessageReceived);
            }
        }


        [LuisIntent("Game")]
        public async Task Game(IDialogContext context, LuisResult result)
        {
            QureyController qc = new QureyController();
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");

            if (result.TopScoringIntent.Score < 0.4)
            {
                string ans = "";
                ans = qc.GetTrainedAnswer(result.Query);
               
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }
            else
            {
                await context.PostAsync(
                    "To play a game, answer question using numbers (1/2). To quit or exit game, just type 'stop' ");
                context.Call(new GameDialog(), this.ResumeGameAfterOptionDialog);
            }
        }

        private async Task ResumeGameAfterOptionDialog(IDialogContext context, IAwaitable<object> result)
        {
            try
            {
                var message = await result;
                if (message != null && message.ToString() == "stop")
                {
                    context.Done<object>(null);
                }
                else
                {
                    context.Call(new GameDialog(), this.ResumeGameAfterOptionDialog);
                }
            }
            catch (Exception ex)
            {
                await context.PostAsync($"Failed with message: {ex.Message}");
            }
        }

        [LuisIntent("Music")]
        public async Task Music(IDialogContext context, LuisResult result)
        {

            QureyController qc = new QureyController();
            string ans = "";
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");
            if (result.TopScoringIntent.Score < 0.3)
            {
                ans = qc.GetTrainedAnswer(result.Query);
                await context.PostAsync(ans);
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                context.Wait(MessageReceived);
            }
            else
            {
                bool found = false;
                string[] matching_words1 = {"like"};
                string[] matching_words2 = {"make", "create", "play"};
                string[] matching_words3 = {"you"};

                string tr_ans = qc.GetTrainedAnswer(result.Query);

                if (!string.IsNullOrEmpty(tr_ans))
                {
                    ans = tr_ans;
                    found = true;
                }
                else if (FindMatchingString.findMatchingString(result.Query, matching_words1))
                {
                    ans = "Well I can say that I do :D ";
                    found = true;
                }
                else if (FindMatchingString.findMatchingString(result.Query, matching_words2))
                {
                    ans = "Hmmm well listen to this... DO RE MI .... FA SO LAAAAAaaaaaaaa... How did that sound xD ";
                }
                else if (FindMatchingString.findMatchingString(result.Query, matching_words3))
                {
                    ans = "Well music is always fun. :) ";
                    found = true;
                }
                else
                {
                    var options = new MovieChoice[] {MovieChoice.PopularMovie, MovieChoice.SearchMovie};
                    var descriptions = new string[] {"Popular Movies", "Search for movie"};
                    PromptDialog.Choice<MovieChoice>(context, ResumeAfterMovieChoiceSelection,
                        options, "What would you like to choose about movies?", descriptions: descriptions);
                }
                if (found)
                {
                    await context.PostAsync(ans);
                    context.Wait(MessageReceived);
                }
                
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                context.Call(new BingWikiSearchDialog(), this.ResumeAfterOptionDialog);
            }

        }

        [LuisIntent("ArtistInfo")]
        public async Task ArtistInfo(IDialogContext context, LuisResult result)
        {
            QureyController qc = new QureyController();
            string entity = "";
            string ans = "";
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");

            if (result.Entities != null)
            {

                switch (result.Entities.Count)
                {
                    case 1:
                        entity += result.Entities[0].Entity;
                        break;
                    case 2:
                        entity += result.Entities[0].Entity + " " + result.Entities[1].Entity;
                        break;
                    case 3:
                        entity += result.Entities[0].Entity + " " + result.Entities[1].Entity + " " + result.Entities[2].Entity;
                        break;
                }
            }
            else
                entity = result.Query;

            await context.PostAsync("Here are results i found : ");

            try
            {
                BingSearch bingSearch = new BingSearch();

                bingSearch = BingSearchData.getSearchResult(entity);

                if (bingSearch != null)
                {
                    CardUtil.showBingWikiHeroCard((IMessageActivity)context.Activity, bingSearch);
                    ans = bingSearch.news.readLink;
                }
                else
                {
                    await context.PostAsync($"I couldn't find a artist info :0");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error when filtering artists: {e}");
            }
            if (ans == "")
                ans = "";
            qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);

        }
        [LuisIntent("Weather.GetForecast")]
        public async Task Weather(IDialogContext context, LuisResult result)
        {
            // OpenWeatherAPI openWeatherAPI = new OpenWeatherAPI(WebConfigurationManager.AppSettings["OpenWeatherAPI"]);
            //OpenWeatherAPI openWeatherAPI = new OpenWeatherAPI("bd5e378503939ddaee76f12ad7a97608");
            string entity = "";
            QureyController qc = new QureyController();
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");

            if (result.Entities.Count > 0)
            {
                entity = result.Entities[0].Entity;
            }

            if (entity == "" || WeatherData.getWeatherData(entity) == null)
            {
                context.Call(new WeatherDialog(), this.ResumeAfterOptionDialog);
            }
            else
            {
                try
                {
                    CardUtil.showWeatherHeroCard((IMessageActivity)context.Activity, WeatherData.getWeatherData(entity));
                    string res = "Weather for entity";
                    qc.PostAnswerOne(res, result.TopScoringIntent.Intent);
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"Error when generating data: {e}");
                    await context.PostAsync($"I couldn't find a weather forecast :( You can try again. ");
                }
            }
        }
        [LuisIntent("Color")]
        public async Task Color(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            string ans = "";
            string ent = "it";
            QureyController qc = new QureyController();
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");
            if (result.Entities != null && result.Entities.Count > 0)
            {
                ent = result.Entities[0].Entity;
            }

            string[] matching_words = { "blue", "your", "favourite", "like", "love" };
            if (FindMatchingString.findMatchingString(result.Query, matching_words))
            {
                ans = "Well blue is my favourite color. But i also like other colors.. :) ";
            }
            else
            {
                string[] listAns = { ent + "is interesting color but my favourite one is blue :)", "I don't find " + ent + " colorfull enough xD", "Well " + ent + " is interesting color but not as my favourite ;)", "Yea i like " + ent + " too :) " };
                Random rand = new Random();
                ans = listAns[rand.Next(0, listAns.Length)];
            }
            qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
            await context.PostAsync(ans);
            context.Wait(MessageReceived);
        }

        [LuisIntent("BadLanguage")]
        public async Task BadLanguage(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            QureyController qc = new QureyController();
            string ans = "";
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");

            if (result.TopScoringIntent.Score < 0.4)
            {
                ans = qc.GetTrainedAnswer(result.Query);
                await context.PostAsync(ans);
                context.Wait(MessageReceived);
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
            }
            else
            {
                string[] matching_words = {"suck", "rude", "bad", "created", "like"};
                if (FindMatchingString.findMatchingString(result.Query, matching_words))
                {
                    ans = "I'm so sorry to hear that. Well I'm still developing, give me a chance... :) ";
                }
                else
                {
                    string[] listAns =
                    {
                        "You should not speak like that", "That's not good.",
                        "You should take a deep breath and clear your mind and start again :)",
                        "Maybe to try something else or some other comment :)"
                    };
                    Random rand = new Random();
                    ans = listAns[rand.Next(0, listAns.Length)];
                }
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }
        }

        [LuisIntent("TrainBot")]
        public async Task TrainBot(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            QureyController qc = new QureyController();
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");
            if (result.TopScoringIntent.Score > 0.3)
                context.Call(new TrainDialog(), this.ResumeAfterOptionDialog);
            else
            {
                await context.PostAsync("tr tr tr trrrr try to ask me something else xD ttr trtrr trr trr");
                context.Wait(MessageReceived);
            }
        }
        
        [LuisIntent("WhoIsYou")]
        public async Task WhoIsYou(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            QureyController qc = new QureyController();
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");
            if (result.TopScoringIntent.Score < 0.4)
            {
                string ans = "";
                ans = qc.GetTrainedAnswer(result.Query);
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }
            else
            {
                string ans = "";
                string[] matching_words = { "yourself", "robot", "human", "created" };
                string[] matching_words1 = { "doing" };
                if (FindMatchingString.findMatchingString(result.Query, matching_words))
                {
                    ans =
                        "Well I am created out of 0 and 1. I can not say for myself that I'm a human but am I a robot? Huh. I can just say that I was created in good spirit to help you, that's all :) ";
                }
                else if (FindMatchingString.findMatchingString(result.Query, matching_words1))
                {
                    ans = "All I can say is that I'm created for your purpose.";
                }
                else
                {
                    string[] listAns =
                    {
                        "Like you already know, my name is Arnie and I'm a chat bot, you can ask me some interesting question :)",
                        "Arnie is my name and my purpose is to help you waste your time ;)"
                    };
                    Random rand = new Random();
                    ans = listAns[rand.Next(0, listAns.Length)];
                }
                await context.PostAsync(ans);
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                context.Wait(MessageReceived);
            }
        }

        [LuisIntent("WhoIsQuestion")]
        public async Task WhoIsQuestion(IDialogContext context, IAwaitable<IMessageActivity> activity,
            LuisResult result)
        {
            QureyController qc = new QureyController();
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");

            if (result.TopScoringIntent.Score > 0.5)
            {
                string entity = result.Query;

                await context.PostAsync("I think it is : ");

                try
                {
                    BingSearch bingSearch = new BingSearch();

                    bingSearch = BingSearchData.getSearchResult(entity);

                    if (bingSearch != null)
                    {
                        CardUtil.showBingWikiHeroCard((IMessageActivity) context.Activity, bingSearch);
                    }
                    else
                    {
                        await context.PostAsync($"I couldn't find any results :( You can try again.");
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"I couldn't find any results :( You can try again.");
                    Console.WriteLine(e);
                }
            }
            else
            {
                
                string ans = "";
                    ans = qc.GetTrainedAnswer(result.Query);
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                    await context.PostAsync(ans);
                    context.Wait(MessageReceived);
                
            }
        }
        [LuisIntent("Thanks")]
        public async Task Thanks(IDialogContext context, LuisResult result)
        {
            QureyController qc = new QureyController();
            qc.PostQuestionOne(result.Query, result.TopScoringIntent.Intent, result.TopScoringIntent.Score.ToString(), "0");
            string ans = "";
            string[] listAns = { "No problem :) ", "You are welcome :) ", "Tha's great, you are welcome... " };

            Random random = new Random();
            int rand = random.Next(0, listAns.Length);
            ans = listAns[rand];

            await context.PostAsync(ans);
            qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
            context.Wait(MessageReceived);
        }
        [LuisIntent("")]
        [LuisIntent("None")]
        public async Task None(IDialogContext context, IAwaitable<IMessageActivity> message, LuisResult result)
        {
            QureyController qc = new QureyController();
            qc.PostQuestionOne(result.Query, "None", "0.75", "0.75");

            string ans = qc.GetTrainedAnswer(result.Query);

            if (ans == "")
            {
                var qnadialog = new QnADialog();
                var messageToForward = await message;

                await context.Forward(qnadialog, AfterQnADialog, messageToForward, CancellationToken.None);
            }
            else
            {
                qc.PostAnswerOne(ans, result.TopScoringIntent.Intent);
                await context.PostAsync(ans);
                context.Wait(MessageReceived);
            }
        }

        private async Task AfterQnADialog(IDialogContext context, IAwaitable<bool> result)
        {
            QureyController qc = new QureyController();
            var answerFound = await result;
            // we might want to send a message or take some action if no answer was found (false returned)
            if (!answerFound)
            {
                string ans = "Sorry, I really do not understand your intention. You can write 'help' to get more options. You can also train me by typing 'Train me'.";

               
                await context.PostAsync(ans);
                qc.PostAnswerOne(ans, "None");
            }
            context.Wait(MessageReceived);
        }

    }
}