using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ChatBot.MusicSearch
{
    public class MusicSearchResult
    {
        [JsonProperty("@odata.context")]
        public string odatacontext { get; set; }
        public Value[] value { get; set; }
    }

    //Data model for fetching facets
    public class FacetResult
    {
        [JsonProperty("@odata.context")]
        public string odatacontext { get; set; }
        [JsonProperty("@search.facets")]
        public SearchFacets searchfacets { get; set; }
        public Value[] value { get; set; }
    }

    public class Value
    {
        [JsonProperty("@search.score")]
        public float searchscore { get; set; }
        public string imageURL { get; set; }
        public string Name { get; set; }
        public string Era { get; set; }
        public string Description { get; set; }
        public string id { get; set; }
        public string rid { get; set; }
    }

    public class SearchFacets
    {
        [JsonProperty("Era@odata.type")]
        public string Eraodatatype { get; set; }
        public Era[] Era { get; set; }
    }

    public class Era
    {
        public int count { get; set; }
        public string value { get; set; }
    }
}