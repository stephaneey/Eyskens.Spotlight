using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyskens.Spotlight
{
    public class SurfaceForm
    {
        [JsonProperty(PropertyName = "@name")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "@offset")]


        public int offset { get; set; }
        public List<SurfaceFormResource> resource { get; set; }
    }
}
