using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ChatBot.Controllers;
using ChatBot.SearchMovies;
using ChatBot.Util;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace ChatBot.Dialogs
{
    [Serializable]
    public class PopularMoviesDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(this.MessageReceivedAsync);
        }

        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            // List of popular movies 
            try
            {
                await context.PostAsync($"I am searching for movies, please be patient :)");

                MoviesSearch search = new MoviesSearch();
                List<Movie> movieResult = await search.GetPopularMovies();
                if (movieResult.Count != 0)
                {
                    await context.PostAsync($"Here is popular movie list : ");
                    CardUtil.showHeroCardMovies((IMessageActivity)context.Activity, movieResult);
                }
                else
                {
                    await context.PostAsync($"I couldn't find list of movies, you can try again.");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error when filtering by popular movies: {e}");
            }
            context.Done(this);

        }
    }
}