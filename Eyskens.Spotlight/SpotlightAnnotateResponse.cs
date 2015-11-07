using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyskens.Spotlight
{
    public class SpotlightAnnotateResponse
    {
        [JsonProperty(PropertyName = "@confidence")]
        public double confidence
        {
            get;
            internal set;
        }

        [JsonProperty(PropertyName = "@policy")]
        public string policy
        {
            get;
            internal set;
        }
        [JsonProperty(PropertyName = "@sparql")]
        public string sparql
        {
            get;
            internal set;
        }
        [JsonProperty(PropertyName = "@support")]
        public double support
        {
            get;
            internal set;
        }
        [JsonProperty(PropertyName = "@text")]
        public string text
        {
            get;
            internal set;
        }
        [JsonProperty(PropertyName = "@types")]
        public string types
        {
            get;
            internal set;
        }
        [JsonProperty(PropertyName = "Resources")]
        public List<SpotlightResource> Resources
        {
            get;
            internal set;
        }
    }
}
