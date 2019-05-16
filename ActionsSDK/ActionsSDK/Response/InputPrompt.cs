using System;
using System.Collections.Generic;

namespace ActionsSDK
{
    public class InputPrompt
    {
        [Obsolete("Only a single initial_prompt is supported")]
        public IList<SpeechResponse> initialPrompts { get; set; }
        public RichResponse richInitialPrompt {get;set;}
        public IList<SimpleResponse> noInputPrompts { get; set; }

        public InputPrompt(RichResponse richResponse)
        {
            richInitialPrompt = richResponse;
        }

        public InputPrompt()
        {
            richInitialPrompt = new RichResponse();
        }
    }
}