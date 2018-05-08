using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using BestMatchDialog;
using ChatBot.Controllers;
using Microsoft.Bot.Builder.Dialogs;

namespace ChatBot.Services
{
    [Serializable]
    public class GreetingsDialog : BestMatchDialog<object>
    {
        [BestMatch(new string[] { "hi", "hi there", "hello there", "hey", "hello",
                "hey there", "greetings", "good morning", "good afternoon", "good evening", "good day" },
            threshold: 0.5, ignoreCase: false, ignoreNonAlphaNumericCharacters: false)]
        public async Task WelcomeGreeting(IDialogContext context, string messageText)
        {
            QureyController qc = new QureyController();
            string ans = qc.GetAnswer(messageText, "Greetings", "0.8", "0");
            await context.PostAsync(ans);
            context.Done(true);
        }

        [BestMatch(new string[] { "bye", "bye bye", "got to go",
            "see you later", "laters", "adios" })]
        public async Task FarewellGreeting(IDialogContext context, string messageText)
        {
            await context.PostAsync("Bye. Have a good day.");
            context.Done(true);
        }

        public override async Task NoMatchHandler(IDialogContext context, string messageText)
        {
            context.Done(false);
        }
    }
}