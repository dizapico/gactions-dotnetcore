using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace ActionsSDK
{
    public class OpenUrlAction
    {
        public string url { get; set; }
        public AndroidApp androidApp { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public UrlTypeHint urlTypeHint { get; set; }
    }

    public enum UrlTypeHint
    {
        URL_TYPE_HINT_UNSPECIFIED,
        AMP_CONTENT
    }

    public class AndroidApp
    {
        public string packageName { get; set; }
        public IList<VersionFilter> versions { get; set; }
    }

    public class VersionFilter
    {
        public float minVersion { get; set; }
        public float maxVersion { get; set; }
    }
}