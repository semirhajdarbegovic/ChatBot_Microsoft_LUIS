using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using QnAMakerDialog;
using QnAMakerResult = Microsoft.Bot.Builder.CognitiveServices.QnAMaker.QnAMakerResult;

namespace ChatBot.QnABot
{
    [Serializable]
    [QnAMakerService("", "")]
    public class QnADialog : QnAMakerDialog<bool>
    {
        public override async Task NoMatchHandler(IDialogContext context, string originalQueryText)
        {
            await context.PostAsync($"Sorry, I couldn't find an answer for '{originalQueryText}'.");
            context.Done(false);
        }

        public async Task DefaultMatchHandler(IDialogContext context, string originalQueryText, QnAMakerResult result)
        {
            await context.PostAsync($"I found an answer that might help...{result.Answer}.");
            context.Done(true);
        }
    }
}