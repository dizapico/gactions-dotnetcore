using System.Collections.Generic;

namespace ActionsSDK
{
    public class PackageEntitlement
    {
        public string packageName { get; set; }
        public IList<Entitlement> entitlements { get; set; }
    }
}