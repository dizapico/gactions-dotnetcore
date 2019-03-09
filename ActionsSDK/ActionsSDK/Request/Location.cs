namespace ActionsSDK
{
    public class Location
    {
        public LatLng coordinates { get; set; }
        public string formattedAddess { get; set; }
        public string zipCode { get; set; }
        public string city { get; set; }
        public PostalAddress postalAddress { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string notes { get; set; }
        public string placeId { get; set; }
    }
}