using System;
using System.Collections.Generic;
using System.Text;

namespace ActionsSDK.Helpers
{
    public class SignIn : ExpectedIntent
    {
        public SignIn() : base("actions.intent.SIGN_IN")
        {
            inputValueData = new Dictionary<string, object>();
            inputValueData.Add("@type", "type.googleapis.com/google.actions.v2.SignInValueSpec");
        }
    }
}
