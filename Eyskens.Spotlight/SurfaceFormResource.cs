using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyskens.Spotlight
{
    public class SurfaceFormResource : SpotlightResource
    {
        [JsonProperty(PropertyName = "@finalScore")]
        public double FinalScore { get; set; }

        [JsonProperty(PropertyName = "@label")]
        public string label { get; set; }

        [JsonProperty(PropertyName = "@priorScore")]
        public double PriorScore { get; set; }
        [JsonProperty(PropertyName = "@contextualScore")]
        public double ContextualScore { get; set; }
    }
}
