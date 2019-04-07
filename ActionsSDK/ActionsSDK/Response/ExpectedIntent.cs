using System;
using System.Collections.Generic;

namespace ActionsSDK
{
    public class ExpectedIntent
    {
        public string intent { get; set; }
        public IDictionary<string, object> inputValueData { get; set; }
        public string parameterName { get; set; }

        public ExpectedIntent(String Intent)
        {
            intent = Intent;
        }
    }
}