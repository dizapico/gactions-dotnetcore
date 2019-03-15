using System.Collections.Generic;

namespace ActionsSDK
{
    public class Surface
    {
        public IList<Capability> capabilities { get; set; }

        public bool Has(string Capability)
        {
            foreach(Capability capability in capabilities)
            {
                if (capability.name.Equals(Capability))
                {
                    return true;
                }
            }
            return false;
        }


        #region AuxCapabilitiesMethods
        public bool HasScreen()
        {
            return Has("actions.capability.SCREEN_OUTPUT");
        }

        public bool HasAudio()
        {
            return Has("actions.capability.AUDIO_OUTPUT");
        }

        public bool HasMediaPlayback()
        {
            return Has("actions.capability.MEDIA_RESPONSE_AUDIO");
        }

        public bool HasWebBrowser()
        {
            return Has("actions.capability.WEB_BROWSER");
        }

        #endregion
    }
}