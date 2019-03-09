using System.Collections.Generic;

namespace ActionsSDK
{
    public class Input
    {
        public IList<RawInput> rawInputs { get; set; }
        public string intent { get; set; }
        public IList<Argument> arguments { get; set; }
    }
}