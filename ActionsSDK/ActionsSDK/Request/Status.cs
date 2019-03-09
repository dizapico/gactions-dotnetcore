using System.Collections.Generic;

namespace ActionsSDK
{
    public class Status
    {
        public float code { get; set; }
        public string message { get; set; }
        public IList<object> details { get; set; }
    }
}