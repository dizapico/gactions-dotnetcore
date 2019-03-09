using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ActionsSDK
{
    public class RawInput
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public InputType inputType { get; set; }
        public string query { get; set; }
        public string url { get; set; }
    }
}