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
   // [Serializable]
    public class WelcomeDialog //: IDialog<object>
    {
        /*public enum UserChoice
        {
            SearchMovie,
            PopularMovie,
            SearchWiki,
            Weather
        }

        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(this.MessageReceivedAsync);
        }

        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var options = new UserChoice[] { UserChoice.SearchWiki, UserChoice.Weather, UserChoice.PopularMovie, UserChoice.SearchMovie };
            var descriptions = new string[] { "Search Wikipedia", "Get Weather Info", "Popular Movies", "Search for movie" };
            PromptDialog.Choice<UserChoice>(context, ResumeAfterMovieChoiceSelection,
                options, "What would you like to choose about movies?", descriptions: descriptions);
        }
        
        public virtual async Task ChildDialogComplete(IDialogContext context, IAwaitable<object> response)
        {
            await context.PostAsync("Thanks for using me as your bot.");
            context.Done(this);
        }
        private async Task ResumeAfterMovieChoiceSelection(IDialogContext context, IAwaitable<UserChoice> result)
        {
            var selection = await result;
            if (selection == WelcomeDialog.UserChoice.PopularMovie)
            {
                context.Call(new PopularMoviesDialog(), this.ResumeAfterOptionDialog);
            }
            else if (selection == WelcomeDialog.UserChoice.SearchMovie)
            {
                context.Call(new SearchMovieDialog(), this.ResumeAfterOptionDialog);
            }
            else if (selection == WelcomeDialog.UserChoice.SearchWiki)
            {
                context.Call(new BingWikiSearchDialog(), this.ResumeAfterOptionDialog);
            }
            else 
            {
                context.Call(new WeatherDialog(), this.ResumeAfterOptionDialog);
            }
        }

        private async Task ResumeAfterOptionDialog(IDialogContext context, IAwaitable<object> result)
        {
            try
            {
                var message = await result;
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
    } */

    }
}