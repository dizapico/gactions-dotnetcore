using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ActionsSDK
{
    public class Action
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ActionType type { get; set; }
        public Button button { get; set; }
    }

    public enum ActionType
    {
        UNKNOWN,
        VIEW_DETAILS,
        MODIFY,
        CANCEL,
        RETURN,
        EXCHANGE,
        EMAIL,
        CALL,
        REORDER,
        REVIEW,
        CUSTOMER_SERVICE,
        FIX_ISSUE
    }
}