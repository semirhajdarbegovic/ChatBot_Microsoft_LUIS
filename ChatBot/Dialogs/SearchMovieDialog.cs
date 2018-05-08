using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ChatBot.SearchMovies;
using ChatBot.Util;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace ChatBot.Dialogs
{
    [Serializable]
    public class SearchMovieDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync("Enter name for a movie to search");
            context.Wait(this.MessageReceivedAsync);
        }

        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var message = await result;

            string entity = "";

            if (message.Text.Length > 0)
            {
                entity = message.Text;
            }

            await context.PostAsync("Here is a movie which i found : ");

            if (entity == "")
            {
                entity = "Star Wars: The Last Jedi";
                
            }
            try
            {
                MoviesSearch search = new MoviesSearch();
                Movie movieResult = await search.SearchByName(entity);
                if (movieResult.id != 0)
                {
                    CardUtil.showHeroCard((IMessageActivity)context.Activity, movieResult);
                }
                else
                {
                    await context.PostAsync($"I couldn't find a movie :/");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error when filtering by genre: {e}");
            }

            context.Done(this);
        }
    }
}