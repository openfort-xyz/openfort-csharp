namespace Openfort.SDK.Model
{
	public class WebHookEvent
	{
		public WebHookEvent(TransactionIntent data, int date)
        {
			Data = data;
			Date = date;
		}

        public TransactionIntent Data { get; set; }

        public int Date { get; set; }
	}
}
