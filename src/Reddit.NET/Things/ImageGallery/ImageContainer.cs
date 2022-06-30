using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reddit.Things
{
    [Serializable]
    public class ImageContainer
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        // The only value I know of here is "Image".
        [JsonProperty("e")]
        public string E { get; set; }

        [JsonProperty("m")]
        public string Metadata { get; set; }

        [JsonProperty("p")]
        public List<Image> ImageVersions { get; set; }

        [JsonProperty("s")]
        public Image OriginalImage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
