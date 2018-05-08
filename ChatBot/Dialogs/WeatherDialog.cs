using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ChatBot.SearchMovies;
using ChatBot.Util;
using ChatBot.WeatherService;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace ChatBot.Dialogs
{
    [Serializable]
    public class WeatherDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            string[] display_msg = {"To be honest, I didn't catch name of city. So could you please enter city name : ",
                                    "Sorry I didn't get city name, write it again : ",
                                    "Hrm. That’s too big of a place to forecast. Can you try to be a little more specific? Write city name :",
                                    "Can you write city name : ",
                                    "Enter city name : "
                                    
            };
            Random rand = new Random();
            int num = rand.Next(0, 4);
            await context.PostAsync(display_msg[num]);
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

            await context.PostAsync("Here is a weather : ");

            if (entity == "")
            {
                entity = "Mostar";
            }
            try
            {
                CardUtil.showWeatherHeroCard((IMessageActivity)context.Activity, WeatherData.getWeatherData(entity));
            }
            catch (Exception e)
            {
                await context.PostAsync($"I couldn't find a weather forecast :( You can try again. ");
            }

            context.Done<object>(null);
        }
    }
}