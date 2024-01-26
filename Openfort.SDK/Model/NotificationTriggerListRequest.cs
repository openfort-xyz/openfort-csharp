namespace Openfort.SDK.Model
{
	public class NotificationTriggerListRequest : BaseExpandableListRequest<string>
	{
		public NotificationTriggerListRequest(string id, int? limit = null, int? skip = null, SortOrder? order = null) : base(limit, skip, order)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}
