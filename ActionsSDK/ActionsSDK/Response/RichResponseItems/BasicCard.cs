using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace ActionsSDK
{
    public class BasicCard
    {
        public string title { get; set; }
        public string subtitle { get; set; }
        public string formattedText { get; set; }
        public Image image { get; set; }
        public IList<Button> buttons { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ImageDisplayOptions imageDisplayOptions { get; set; }
    }

    public enum ImageDisplayOptions
    {
        DEFAULT,
        WHITE,
        CROPPED
    }
}