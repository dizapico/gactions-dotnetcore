using System;
using System.Collections.Generic;

namespace ActionsSDK
{
    public class Argument
    {
        public string name { get; set; }
        public string rawText { get; set; }
        public string textValue { get; set; }
        public Status status { get; set; }
        public string intValue { get; set; }
        public float floatValue { get; set; }
        public bool boolValue { get; set; }
        public DateTime datetimeValue { get; set; }
        public Location placeValue { get; set; }
        public IDictionary<string, object> extension { get; set; }
        public object structuredValue { get; set; }
    }
}