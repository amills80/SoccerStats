using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerStats
{

    public class SentimentResponse
    {
        [JsonProperty(PropertyName = "documents")]
        public List<Sentiment> Sentiments { get; set; }
    }

    public class Sentiment
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "score")]
        public string Score { get; set; }
    }

}
