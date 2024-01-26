namespace Openfort.SDK.Model
{
	public class NotificationListRequest : BaseExpandableListRequest<NotificationResponseExpandable>
	{
		public NotificationListRequest(int? limit = null, int? skip = null, SortOrder? order = null, List<NotificationResponseExpandable> expand = null, bool? deleted = null, string name = null) : base(limit, skip, order, expand)
		{
			Name = name;
			Deleted = deleted;
		}

		public string Name { get; set; }
		public bool? Deleted { get; set; }
	}
}

