using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyskens.Spotlight
{
    public class Annotation
    {
        [JsonProperty(PropertyName = "@text")]
        public string text { get; set; }

        [JsonProperty(PropertyName = "surfaceForm")]
        public List<SurfaceForm> surfaceForm { get; set; }
    }
}
