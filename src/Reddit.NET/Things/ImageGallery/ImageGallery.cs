using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reddit.Things
{
    [Serializable]
    public class ImageGallery
    {
        [JsonProperty("items")]
        public Dictionary<string, ImageContainer> ImageContainers { get; set; }
    }
}