using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

namespace ChatBot.Services
{
    public class TextAnalyticsAPIService
    {
        public static List<string> getAnalitcsResult(string inputText)
        {
            ITextAnalyticsAPI client = new TextAnalyticsAPI();
            client.AzureRegion = AzureRegions.Westcentralus;
            client.SubscriptionKey = "";

            List<string> strList = new List<string>();


            KeyPhraseBatchResult result2 = client.KeyPhrases(
                new MultiLanguageBatchInput(
                    new List<MultiLanguageInput>()
                    {
                        new MultiLanguageInput("en", "1", inputText)
                    }));
            strList.Add(result2.Documents[0].KeyPhrases[0]);

            SentimentBatchResult result3 = client.Sentiment(
                new MultiLanguageBatchInput(
                    new List<MultiLanguageInput>()
                    {
                        new MultiLanguageInput("en", "1", inputText)
                    }));

            strList.Add(result3.Documents[0].Score.ToString());
            return strList;
        }
    }
}