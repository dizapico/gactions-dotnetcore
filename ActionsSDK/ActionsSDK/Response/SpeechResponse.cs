namespace ActionsSDK
{
    public class SpeechResponse
    {
        //can be only one of the following
        public string textToSpeech { get; set; }
        public string ssml { get; set; }
    }
}