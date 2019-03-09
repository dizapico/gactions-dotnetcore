using System;
using System.Collections.Generic;

namespace ActionsSDK
{
    public class RichResponse
    {
        public IList<Item> items { get; set; }
        public IList<Suggestion> suggestions { get; set; }
        
        public LinkOutSuggestion linkOutSuggestion { get; set; }

        public RichResponse(SimpleResponse SimpleResponse)
        {
            items = new List<Item>();
            items.Add(new Item
            {
                simpleResponse = SimpleResponse
            });
        }
    }

    public class LinkOutSuggestion
    {
        public string destinationName { get; set; }
        [Obsolete("Use OpenUrlAction")]
        public string url { get; set; }
        public OpenUrlAction openUrlAction { get; set; }
    }

    public class Suggestion
    {
        public string title { get; set; }

    }
}