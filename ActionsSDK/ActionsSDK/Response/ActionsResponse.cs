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

        //TODO: Antes de serializar asignar ExpectedInput en la lista y comentar que por ahora Actions solo soporta un ExpectedInput


        public ActionsResponse(ActionsRequest ActionsRequest)
        {
            this.ActionsRequest = ActionsRequest;
            ExpectedInput = new ExpectedInput();
        }

        public void AddHelper(RichResponse richResponse, ExpectedIntent expectedIntent)
        {
            if (expectedInputs == null)
            {
                expectedInputs = new List<ExpectedInput>();
            }
            expectUserResponse = true;


            expectedInputs.Add(new ExpectedInput(new InputPrompt(richResponse), expectedIntent));
        }

        public void AddSimpleResponse(SimpleResponse SimpleResponse)
        {
            if (ActionsRequest.surface.HasAudio() || ActionsRequest.surface.HasScreen())
            {
                //TODO: Pasar los que no cumple
                throw new NotSupportedException();
            }


        }

    }
}
