using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace ActionsSDK
{
    public class CarouselBrowse
    {
        public IList<Item> items { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ImageDisplayOptions imageDisplayOptions { get; set; }
    }
}