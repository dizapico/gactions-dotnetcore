namespace ActionsSDK
{
    public class CustomPushMessage
    {
        public Target target { get; set; }
        //can be only one of the following
        public OrderUpdate orderUpdate { get; set; }
        public UserNotification userNotification { get; set; }
    }

    public class Target
    {
        public string userId { get; set; }
        public string intent { get; set; }
        public Argument argument { get; set; }
        public string locale { get; set; }

    }
}