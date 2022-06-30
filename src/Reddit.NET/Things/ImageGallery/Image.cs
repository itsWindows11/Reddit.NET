using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reddit.Things
{
    [Serializable]
    public class Image
    {
        [JsonProperty("x")]
        public int Width { get; set; }

        [JsonProperty("y")]
        public int Height { get; set; }

        [JsonProperty("u")]
        public string Url { get; set; }
    }
}
