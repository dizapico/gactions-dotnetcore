using Newtonsoft.Json;
using System;

namespace ActionsSDK
{
    public class Item
    {
        [JsonProperty]
        private string name { get; set; }
        //can be only one of the following
        [JsonProperty]
        private SimpleResponse simpleResponse { get; set; }
        [JsonProperty]
        private BasicCard basicCard { get; set; }
        [JsonProperty]
        private StructuredResponse structuredResponse {get;set;}
        [JsonProperty]
        private MediaResponse mediaResponse { get; set; }
        [JsonProperty]
        private CarouselBrowse carouselBrowse { get; set; }
        [JsonProperty]
        private TableCard tableCard { get; set; }

        public Item(SimpleResponse SimpleResponse, string Name)
        {
            name = Name;
            simpleResponse = SimpleResponse;
        }

        public Item(BasicCard BasicCard, string Name)
        {
            name = Name;

            basicCard = BasicCard;
        }

        public Item(StructuredResponse StructuredResponse, string Name)
        {
            name = Name;
            structuredResponse = StructuredResponse;
        }

        public Item(MediaResponse MediaResponse, string Name)
        {
            name = Name;
            mediaResponse = MediaResponse;
        }

        public Item(CarouselBrowse CarouselBrowse, string Name)
        {
            name = Name;
            carouselBrowse = CarouselBrowse;
        }

        public Item(TableCard TableCard, string Name)
        {
            name = Name;
            tableCard = TableCard;
        }
        public Type GetRichResponseType()
        {
            if (simpleResponse != null)
            {
                return simpleResponse.GetType();
            }else if(basicCard != null)
            {
                return basicCard.GetType();
            }else if(structuredResponse != null)
            {
                return structuredResponse.GetType();
            }else if(mediaResponse != null)
            {
                return mediaResponse.GetType();
            }else if(carouselBrowse != null)
            {
                return carouselBrowse.GetType();
            }else if (tableCard != null)
            {
                return tableCard.GetType();
            }
            else
            {
                throw new Exception("No rich response implemented in RichInitialPromopt -> Item");
            }

        }
    }
}