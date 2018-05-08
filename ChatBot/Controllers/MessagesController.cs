using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.Http;
using ChatBot.Controllers;
using ChatBot.Dialogs;
using LuisBot.Services;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Activity = Microsoft.Bot.Connector.Activity;

namespace ChatBot
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        private static readonly bool IsSpellCorrectionEnabled = bool.Parse(WebConfigurationManager.AppSettings["IsSpellCorrectionEnabled"]);

        private readonly BingSpellCheckService spellService = new BingSpellCheckService();

        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        {
            
               if (activity.Type == ActivityTypes.Message)
               {
                   var connector = new ConnectorClient(new Uri(activity.ServiceUrl));
                   Activity isTypingReply = activity.CreateReply();
                   isTypingReply.Type = ActivityTypes.Typing;
                   await connector.Conversations.ReplyToActivityAsync(isTypingReply);
                   await Conversation.SendAsync(activity, () => new Dialogs.RootDialog());
               }
               else
               {
                   HandleSystemMessage(activity);
               }
               var response = Request.CreateResponse(HttpStatusCode.OK);
               return response;

          /*  if (activity.Type == ActivityTypes.Message)
            {
                if (IsSpellCorrectionEnabled)
                {
                    try
                    {
                        activity.Text = await this.spellService.GetCorrectedTextAsync(activity.Text);
                    }
                    catch (Exception ex)
                    {
                        Trace.TraceError(ex.ToString());
                    }
                }

                await Conversation.SendAsync(activity, () => new RootDialog());
            }
            else
            {
                HandleSystemMessage(activity);
            }

            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;*/
        }

        private Activity HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                // Handle conversation state changes, like members being added and removed
                // Use Activity.MembersAdded and Activity.MembersRemoved and Activity.Action for info
                // Not available in all channels

                // Note: Add introduction here:
                string msg = "Hello there! My name is Arnie Bot and I am here to assist you. You can start by typing things like 'Hello' or 'How are you' or 'Can you give me advice' ... STry one of those : Let's play game, How are you, What's the weather like today, List popular Movies... And if you get stuck or you want to check basic functionality, just type 'help' or 'settings'.";

                IConversationUpdateActivity update = message;
                var client = new ConnectorClient(new Uri(message.ServiceUrl), new MicrosoftAppCredentials());
                if (update.MembersAdded != null && update.MembersAdded.Any())
                {
                    foreach (var newMember in update.MembersAdded)
                    {
                        if (newMember.Id != message.Recipient.Id)
                        {
                            
                              var reply = message.CreateReply();
                                

                            reply.Text = msg;

                            client.Conversations.ReplyToActivityAsync(reply);

                            Session session = new Session();
                              session.Date = DateTime.Now;
                              QureyController qc = new QureyController();
                              qc.PostSession(session);
                        }
                    }
                }
               
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing tha the user is typing
            }
            else if (message.Type == ActivityTypes.Ping)
            {
            }

            return null;
        }
    }
}