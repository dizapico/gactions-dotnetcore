using System.Collections.Generic;

namespace ActionsSDK
{
    public class LineItemUpdate
    {
        public OrderState orderState { get; set; }
        public Price price { get; set; }
        public string reason { get; set; }
        public IDictionary<string, object> extension { get; set; }
    }
}