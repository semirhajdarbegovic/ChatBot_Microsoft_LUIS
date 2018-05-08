using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ChatBot.Controllers;
using ChatBot.Game;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace ChatBot.Dialogs
{
    [Serializable]
    public class TrainDialog : IDialog<object>
    {
        private string question = "";
        private string answer = "";

        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync("Would you like to train me? Type (yes/no).");
            context.Wait(this.MessageReceivedAsync);
        }

        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var message = await result;

            string entity = "";

            if (message.Text.Length > 0)
            {
                if (message.Text.ToLower() == "yes" || message.Text.ToLower() == "'yes'")
                {
                    PromptDialog.Text(
                        context: context,
                        resume: ResumeGetQuesion,
                        prompt: "Please your question :",
                        retry: "Sorry, I didn't understand that. Please try again."
                    );
                }
                else if (message.Text.ToLower() == "no" || message.Text.ToLower() == "'no'")
                {
                    await context.PostAsync("Thanks for training me :)");
                    context.Done(this);

                }
                else
                {
                    await context.PostAsync("Enter 'yes' or 'no'.");
                    context.Wait(this.MessageReceivedAsync);
                }
            }


        }
        public virtual async Task ResumeGetQuesion(IDialogContext context, IAwaitable<string> Username)
        {
            string response = await Username;
            question = response; 

            PromptDialog.Text(
                context: context,
                resume: ResumeGetAnswer,
                prompt: "Please enter answer for your question : ",
                retry: "Sorry, I didn't understand that. Please try again."
            );
        }
        public virtual async Task ResumeGetAnswer(IDialogContext context, IAwaitable<string> mobile)
        {
            string response = await mobile;
            answer = response;

            try
            {
                QureyController qc = new QureyController();
                qc.PostTrainedAnswer(question, answer);
            }
            finally
            {
                await context.PostAsync("Thanks for training me. If you would like to add more, just type 'train'");
                context.Done(this);
            }
        }
    }
}