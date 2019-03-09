using System;
using System.Collections.Generic;
using System.Text;

namespace ActionsSDK
{
    public class ActionsResponse
    {
        public string conversationToken { get; set; }
        public string userStorage { get; set; }
        public bool resetUserStorage { get; set; }
        public bool expectUserResponse { get; set; }
        public IList<ExpectedInput> expectedInputs { get; set; }
        public FinalResponse finalResponse { get; set; }
        public CustomPushMessage customPushMessage { get; set; }
        public bool isInSandbox { get; set; }

        public void AddHelper(RichResponse richResponse, ExpectedIntent expectedIntent)
        {
            if (expectedInputs == null)
            {
                expectedInputs = new List<ExpectedInput>();
            }
            expectUserResponse = true;


            expectedInputs.Add(new ExpectedInput(new InputPrompt(richResponse), expectedIntent));
            
        }
    }
}
