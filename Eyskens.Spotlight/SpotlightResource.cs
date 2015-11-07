using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyskens.Spotlight
{
    public class SpotlightResource
    {
        [JsonProperty(PropertyName = "@URI")]
        public string uri { get; set; }
        [JsonProperty(PropertyName = "@support")]
        public double support { get; set; }

        [JsonProperty(PropertyName = "@types")]
        public string types { get; set; }

        [JsonProperty(PropertyName = "@surfaceForm")]
        public string surfaceForm { get; set; }

        [JsonProperty(PropertyName = "@offset")]
        public int offset { get; set; }

        [JsonProperty(PropertyName = "@similarityScore")]
        public double similarityScore { get; set; }

        [JsonProperty(PropertyName = "@percentageOfSecondRank")]
        public double percentageOfSecondRank { get; set; }
    }
}
