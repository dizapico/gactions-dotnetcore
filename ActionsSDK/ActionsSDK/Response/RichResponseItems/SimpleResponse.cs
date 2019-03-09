namespace ActionsSDK
{
    public class SimpleResponse
    {
        public string textToSpeech { get; set; }
        public string ssml { get; set; }
        public string displayText { get; set; }

        public SimpleResponse(string TextToSpeech)
        {
            textToSpeech = TextToSpeech;
        }
    }
}