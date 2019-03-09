using System.Collections.Generic;

namespace ActionsSDK
{
    public class SignedData
    {
        public IDictionary<string,object> inAppPurchaseData { get; set; }
        public string inAppDataSignature { get; set; }
    }
}