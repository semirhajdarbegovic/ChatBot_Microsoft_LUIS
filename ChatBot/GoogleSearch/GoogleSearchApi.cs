using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;

namespace ChatBot.GoogleSearch
{
    public class GoogleSearchApi
    {
        public static List<GoogleSearchList> getSearchResult(string query)
        {
            string apiKey = "";
            string cx = "";
            
            List<GoogleSearchList> searchList = new List<GoogleSearchList>();

            if(query.Length < 1)
                query = "Harry Potter";

            var customSearchService = new CustomsearchService(new BaseClientService.Initializer { ApiKey = apiKey });
            var listRequest = customSearchService.Cse.List(query);
            listRequest.Cx = cx;

            IList<Result> paging = new List<Result>();
            var count = 0;
            while (paging != null)
            {
                listRequest.Start = count * 10 + 1;
                paging = listRequest.Execute().Items;
                if (paging != null)
                    foreach (var item in paging)
                    {
                        GoogleSearchList sl = new GoogleSearchList();
                        sl.Title = item.Title;
                        sl.Link = item.Link;
                        sl.ImagePath = item.Image == null ? "http://cs.carleton.edu/cs_comps/1617/dialogue/final-results/images/cognitive-services.png" : item.Image.ThumbnailLink;
                        sl.Snippet = item.Snippet;
                        searchList.Add(sl);
                    }
                count++;

                if (count == 1)
                    break;
            }
            return searchList;
        }    
    }
}