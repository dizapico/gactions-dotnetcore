using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionsSDK
{
    public class User
    {
        public String userId { get; set; }
        public String idToken { get; set; }
        public UserProfile profile { get; set; }
        public String accessToken { get; set; }
        [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
        public IList<Permission> permissions { get; set; }
        public String locale { get; set; }
        public String lastSeen { get; set; }
        public String userStorage { get; set; }
        public IList<PackageEntitlement> packageEntitlements { get; set; }

    }
}
