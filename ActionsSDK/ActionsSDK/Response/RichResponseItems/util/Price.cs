using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ActionsSDK
{
    public class Price
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public PriceType type { get; set; }
        public Money amount { get; set; }
    }

    public class Money
    {
        public string currencyCode { get; set; }
        public string units { get; set; }
        public decimal nanos { get; set; }
    }

    public enum PriceType
    {
        UNKNOWN,
        ESTIMATE,
        ACTUAL
    }
}