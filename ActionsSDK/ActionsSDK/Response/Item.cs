namespace ActionsSDK
{
    public class Item
    {
        public string name { get; set; }
        //can be only one of the following
        public SimpleResponse simpleResponse { get; set; }
        public BasicCard basicCard { get; set; }
        public StructuredResponse structuredResponse {get;set;}
        public MediaResponse mediaResponse { get; set; }
        public CarouselBrowse carouselBrowse { get; set; }
        public TableCard tableCard { get; set; }
    }
}