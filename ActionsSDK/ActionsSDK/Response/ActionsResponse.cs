using Newtonsoft.Json;
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

        [JsonIgnore]
        private ExpectedInput ExpectedInput { get; set; }
        public FinalResponse finalResponse { get; set; }
        public CustomPushMessage customPushMessage { get; set; }
        public bool isInSandbox { get; set; }

        [JsonIgnore]
        private ActionsRequest ActionsRequest { get; set; }

        

        public ActionsResponse(ActionsRequest ActionsRequest)
        {
            this.ActionsRequest = ActionsRequest;
            ExpectedInput = new ExpectedInput();
            expectedInputs = new List<ExpectedInput>();
       
        }

        public bool IsRequestWelcome()
        {
            return ActionsRequest.IsWelcome();
        }

        public bool IsSignIn()
        {
            return ActionsRequest.IsSignIn();
        }

        public string GetEmail()
        {
            return ActionsRequest.GetEmail();
        }

        public void AddHelper(RichResponse RichResponse, ExpectedIntent ExpectedIntent)
        {
            if (expectedInputs == null)
            {
                expectedInputs = new List<ExpectedInput>();
            }
            expectUserResponse = true;


            expectedInputs.Add(new ExpectedInput(new InputPrompt(RichResponse), ExpectedIntent));
        }

        public void AddSimpleResponse(SimpleResponse SimpleResponse)
        {
            if (ActionsRequest.HasAudio() || ActionsRequest.HasScreen())
            {
                expectUserResponse = true;
                if (expectedInputs.Count > 0)
                {
                    expectedInputs = new List<ExpectedInput>();
                }
                var richResponse = new RichResponse();
                richResponse.AddSimpleResponse(SimpleResponse);
                expectedInputs.Add(new ExpectedInput(new InputPrompt(richResponse), new ExpectedIntent("actions.intent.TEXT")));
            }
        }
        public string GetFirstSimpleResponse()
        {
            var responses = GetSimpleResponses();
            if (responses.Count > 0)
            {
                return responses[0].displayText;
            }
            else
            {
                return String.Empty;
            }
        }


        private List<SimpleResponse> GetSimpleResponses()
        {
            if(expectedInputs != null && expectedInputs[0] != null)
            {
                var expectedInput = expectedInputs[0];
                if(expectedInput.inputPrompt != null)
                {
                    var imputPrompt = expectedInput.inputPrompt;
                    if(imputPrompt.richInitialPrompt != null)
                    {
                        var richResponse = imputPrompt.richInitialPrompt;
                        return richResponse.GetAllSimpleResponse();
                    }
                }
            }
            return new List<SimpleResponse>();
        }
    }
}
