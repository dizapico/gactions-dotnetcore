using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace ActionsSDK
{
    public class StructuredResponse
    {
        public OrderUpdate orderUpdate { get; set; }
    }

    public class OrderUpdate
    {
        public string googleOrderId { get; set; }
        public string actionOrderId { get; set; }
        public OrderState orderState { get; set; }
        public IList<Action> orderManagementActions { get; set; }
        public Receipt receipt { get; set; }
        public string updateTime { get; set; }
        public Price totalPrice { get; set; }
        public IDictionary<string, LineItemUpdate> lineItemUpdates { get; set; }
        public UserNotification userNotification { get; set; }
        public IDictionary<string, object> infoExtension { get; set; }

        //can be only one of the following
        public RejectionInfo rejectionInfo { get; set; }
        public CancellationInfo cancellationInfo { get; set; }
        public InTransitInfo inTransitInfo { get; set; }
        public FulfillmentInfo fulfillmentInfo { get; set; }
        public ReturnInfo returnInfo { get; set; }
    }

    public class Receipt
    {
        [Obsolete("Pass the field through OrderUpdate.action_order_id")]
        public string confirmedActionOrderId { get; set; }
        public string userVisibleOrderId { get; set; }
    }

    public class OrderState
    {
        public string state { get; set; }
        public string label { get; set; }
    }

    public class ReturnInfo
    {
        public string reason { get; set; }
    }

    public class FulfillmentInfo
    {
        public string deliveryTime { get; set; }
    }

    public class InTransitInfo
    {
        //timestamp RFC3339 UTC
        public string updateTime { get; set; }
    }

    public class CancellationInfo
    {
        public string reason { get; set; }
    }

    public class RejectionInfo
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ReasonType type { get; set; }
        public string reason { get; set; }
    }

    public enum ReasonType
    {
        UNKNOWN,
        PAYMENT_DECLINED,
        INELIGIBLE,
        PROMO_NOT_APPLICABLE,
        UNAVAILABLE_SLOT
    }
}