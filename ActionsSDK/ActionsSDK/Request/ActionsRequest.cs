using ActionsSDK.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.Serialization;

namespace ActionsSDK
{
    [Serializable]
    public class ActionsRequest 
    {
        public User user { get; set; }
        public Device device { get; set; }
        [JsonProperty]
        private Surface surface { get; set; }
        public Conversation conversation { get; set; }
        public IList<Input> inputs { get; set; }
        public bool isInSandbox { get; set; }
        public IList<Surface> availableSurfaces { get; set; }
        [JsonIgnore]
        private GoogleAccount Account { get; set; }
        
        public bool IsWelcome()
        {
            foreach(var input in inputs)
            {
                if (input.intent.Equals("actions.intent.MAIN"))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSignIn()
        {
            return Account != null;
        }

        public string GetEmail()
        {
            if(Account.email != null)
            {
                return Account.email;
            }
            else
            {
                return "";
            }

        }

        #region Capabilities

        public bool HasScreen()
        {
            if(surface!= null)
            {
                return surface.HasScreen();
            }
            return false;
        }

        public bool HasAudio()
        {
            if(surface != null)
            {
                return surface.HasAudio();
            }
            return false;
        }

        public bool HasMediaPlayback()
        {
            if(surface != null)
            {
                return surface.HasMediaPlayback();
            }
            return false;
        }

        public bool HasWebBrowser()
        {
            if(surface != null)
            {
                return surface.HasWebBrowser();
            }
            return false;
        }

        #endregion


        [OnDeserialized]
        private void ExtractGoogleAccountInfo(StreamingContext Context)
        {
            if (user != null && !String.IsNullOrEmpty(user.idToken))
            {
                string payload = user.idToken.Split('.')[1];
                //Complete base64 payload
                int mod4 = payload.Length % 4;
                for(int i = 0; i < mod4; i++)
                {
                    payload += "=";
                }
                string decodedPayload = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(payload));
                Account = JsonConvert.DeserializeObject<GoogleAccount>(decodedPayload);
            }
        }
        
    }
}
