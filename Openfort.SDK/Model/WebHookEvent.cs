namespace Openfort.SDK.Model
{
    public class WebHookEvent
    {
        public WebHookEvent(TransactionIntent data, int date, APITopic type)
        {
            Data = data;
            Date = date;
            Type = type;
        }

        public TransactionIntent Data { get; set; }

        public int Date { get; set; }

        public APITopic Type { get; set; }
    }
}
