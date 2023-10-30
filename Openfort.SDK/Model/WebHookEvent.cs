namespace Openfort.SDK.Model
{
	public class WebHookEvent
	{
		public WebHookEvent(TransactionIntent data, int date, WebHookEventType type)
        {
			Data = data;
			Date = date;
			Type = type;
		}

        public TransactionIntent Data { get; set; }

        public int Date { get; set; }

		public WebHookEventType Type { get; set; }
    }
}
