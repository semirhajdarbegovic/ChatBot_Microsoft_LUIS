using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using ChatBot.Services;

namespace ChatBot.BingSearchApi
{
    public class BingSearchData
    {
        // Replace the accessKey string value with your valid access key.
        //Key 1: f2d8f1e9cc474962a7ab8ff64aa9631a

        //Key 2: b93c52c3d17341f6a6ef41ee9b07133e
        // Old => "18eaa676a1174e23b6d0cd03b960ae70";
        const string accessKey = "f2d8f1e9cc474962a7ab8ff64aa9631a";

        // Verify the endpoint URI.  At this writing, only one endpoint is used for Bing
        // search APIs.  In the future, regional endpoints may be available.  If you
        // encounter unexpected authorization errors, double-check this value against
        // the endpoint for your Bing Web search instance in your Azure dashboard.
        const string uriBase = "https://api.cognitive.microsoft.com/bing/v7.0/search";

        public static BingSearch getSearchResult(string searchQuery)
        {
            BingSearch bs = new BingSearch();

            bs = Newtonsoft.Json.JsonConvert.DeserializeObject<BingSearch>(BingWebSearch(searchQuery).jsonResult);

            return bs;
        } 

        // Used to return search results including relevant headers
        struct SearchResult
        {
            public String jsonResult;
            public Dictionary<String, String> relevantHeaders;
        }

        static SearchResult BingWebSearch(string searchQuery)
        {
            // Construct the URI of the search request
            var uriQuery = uriBase + "?q=" + Uri.EscapeDataString(searchQuery);

            // Perform the Web request and get the response
            WebRequest request = HttpWebRequest.Create(uriQuery);
            request.Headers["Ocp-Apim-Subscription-Key"] = accessKey;
            HttpWebResponse response = (HttpWebResponse)request.GetResponseAsync().Result;
            string json = new StreamReader(response.GetResponseStream()).ReadToEnd();

            // Create result object for return
            var searchResult = new SearchResult()
            {
                jsonResult = json,
                relevantHeaders = new Dictionary<String, String>()
            };

            // Extract Bing HTTP headers
            foreach (String header in response.Headers)
            {
                if (header.StartsWith("BingAPIs-") || header.StartsWith("X-MSEdge-"))
                    searchResult.relevantHeaders[header] = response.Headers[header];
            }

            return searchResult;
        }
    }
}