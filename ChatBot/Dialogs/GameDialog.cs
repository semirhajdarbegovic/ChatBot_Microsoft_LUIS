using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ChatBot.Game;
using ChatBot.SearchMovies;
using ChatBot.Util;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace ChatBot.Dialogs
{
    [Serializable]
    public class GameDialog : IDialog<object>
    {
        private static Random rand = new Random();
        private int num = rand.Next(0, 5);
        private bool finish = false;

        public enum OptionChoose
        {
            First,
            Second,
            Exit
        }

        public async Task StartAsync(IDialogContext context)
        {
            if (finish)
            {
                context.Done(this);
                finish = false;
            }
            else
            {
                await context.PostAsync(GameData.getQuestion(num).question);
                //context.Wait(this.QuestionPrompt);
                this.QuestionPrompt(context, new AwaitableFromItem<IDialogContext>(context));
            }


        }

        private void QuestionPrompt(IDialogContext context, IAwaitable<IDialogContext> result)
        {
            var options = new OptionChoose[]
            {
                OptionChoose.First, OptionChoose.Second, OptionChoose.Exit
            };
            var descriptions = new string[]
            {
                "First Option", "Second Option", "Exit game"
            };
            PromptDialog.Choice<OptionChoose>(context, ResumeAfterDialogChoiceSelection,
                options, "Select one of options : ",
                descriptions: descriptions);
        }

        private async Task ResumeAfterDialogChoiceSelection(IDialogContext context, IAwaitable<OptionChoose> result)
        {
            var selection = await result;
            if (selection == OptionChoose.First)
            {
                await context.PostAsync(GameData.getQuestion(num).answer);
                num = rand.Next(0, 5);
                await StartAsync(context);
            }
            else if (selection == OptionChoose.Second)
            {
                await context.PostAsync(GameData.getQuestion(num).answer);
                num = rand.Next(0, 5);
                await StartAsync(context);
            }
            else
            {
                await context.PostAsync("Thanks for playing game :)");
                context.Done(this);
                context.Done<object>(null);
            
            }
        }
    }
}