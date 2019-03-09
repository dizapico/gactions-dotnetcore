using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ActionsSDK
{
    public class Conversation
    {
        public string conversationId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ConversationType type { get; set; }
        public string conversationToken { get; set; }
    }
}