using System;

namespace ActionsSDK
{
    public class FinalResponse
    {
        //can be only one of the following
        [Obsolete("Use richResponse")]
        public SpeechResponse speechResponse { get; set; }
        public RichResponse richResponse { get; set; }
    }
}