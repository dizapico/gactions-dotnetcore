using System.Collections.Generic;

namespace ActionsSDK
{
    public class PostalAddress
    {
        public float revision { get; set; }
        public string regionCode { get; set; }
        public string languageCode { get; set; }
        public string sortingCode { get; set; }
        public string admnistrativeArea { get; set; }
        public string locality { get; set; }
        public string sublocality { get; set; }
        public IList<string> addressLines { get; set; }
        public IList<string> recipients { get; set; }
        public string organization { get; set; }
    }
}