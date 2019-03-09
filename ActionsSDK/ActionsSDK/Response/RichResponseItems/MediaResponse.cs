using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace ActionsSDK
{
    public class MediaResponse
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public MediaType mediaType { get; set; }
        public IList<MediaObject> mediaObjects { get; set; }
        
    }

    public class MediaObject
    {
        public string name { get; set; }
        public string description { get; set; }
        public string contentUrl { get; set; }

        //can be only one of the following
        public Image largeImage { get; set; }
        public Image icon { get; set; }
    }

    public enum MediaType
    {
        MEDIA_TYPE_UNSPECIFIED,
        AUDIO
    }
}