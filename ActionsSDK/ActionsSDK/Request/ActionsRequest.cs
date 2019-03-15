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
        public Device devide { get; set; }
        public Surface surface { get; set; }
        public Conversation conversation { get; set; }
        public IList<Input> inputs { get; set; }
        public bool isInSandbox { get; set; }
        public IList<Surface> availableSurfaces { get; set; }
        [JsonIgnore]
        private GoogleAccount Account { get; set; }
        

        [OnDeserialized]
        private void OnDeserializeJWT(StreamingContext Context)
        {
            if (user != null && !String.IsNullOrEmpty(user.idToken))
            {
                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                bool readableToke = handler.CanReadToken(user.idToken);
                if (readableToke)
                {
                    JwtSecurityToken stringToken = handler.ReadJwtToken(user.idToken);
                }
            }
        }
        
    }
}
