using System;

namespace ActionsSDK
{
    public class Entitlement
    {
        public String sku { get; set;}
        public String skuType { get; set; }
        public SignedData inAppDetails { get; set; }
    }
}