using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ActionsSDK
{
    public class RichResponse
    {
        [JsonProperty]
        private List<Item> items { get; set; }
        public List<Suggestion> suggestions { get; set; }
        
        public LinkOutSuggestion linkOutSuggestion { get; set; }

        public RichResponse()
        {
            items = new List<Item>();
        }

        public bool AddSimpleResponse(SimpleResponse SimpleResponse, string Name = null)
        {
            // At most two SimpleResponse
            if(items.FindAll(x=>x.GetRichResponseType() == typeof(SimpleResponse)).Count >= 2)
            {
                return false;
            }
            // One SimpleResponse ever first
            if(items.Count>0 && items[0].GetRichResponseType() != typeof(SimpleResponse))
            {
                items.Insert(0, new Item(SimpleResponse, Name));
                return true;
            }
            else
            {
                items.Add(new Item(SimpleResponse, Name));
                return false;
            }
        }

        public bool AddBasicCard(BasicCard BasicCard, string Name = null)
        {
            // at most one card
            if(items.FindAll(x=>x.GetRichResponseType() == typeof(BasicCard) 
                || x.GetRichResponseType() == typeof(StructuredResponse)).Count > 0)
            {
                return false;
            }
            else
            {
                items.Add(new Item(BasicCard, Name));
                return true;
            }
        }

        public List<SimpleResponse> GetAllSimpleResponse()
        {
            var simpleResponsesList = new List<SimpleResponse>();
            foreach (Item item in items)
            {
                if(item.GetRichResponseType() == typeof(SimpleResponse))
                {
                    simpleResponsesList.Add(item.simpleResponse);
                }
            }
            return simpleResponsesList;
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