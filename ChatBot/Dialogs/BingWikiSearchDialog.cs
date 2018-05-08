using System;
using System.Diagnostics;
using System.Threading.Tasks;
using ChatBot.BingSearchApi;
using ChatBot.Controllers;
using ChatBot.Services;
using ChatBot.Util;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace ChatBot.Dialogs
{
    [Serializable]
    public class BingWikiSearchDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync("Enter what you like to search for");
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

            await context.PostAsync("Here are results i found : ");

            try
            {
                BingSearch bingSearch = new BingSearch();
                
                bingSearch = BingSearchData.getSearchResult(entity);

                if (bingSearch != null)
                {
                    CardUtil.showBingWikiHeroCard((IMessageActivity)context.Activity, bingSearch);
                    QureyController qc = new QureyController();
                    qc.PostAnswerOne(bingSearch.entities.readLink, "BingSearch");
                }
                else
                {
                    await context.PostAsync($"I couldn't find what you asked, you can always try again..");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error when filtering by genre: {e}");
            }

            context.Done<object>(null);
        }
    }
}