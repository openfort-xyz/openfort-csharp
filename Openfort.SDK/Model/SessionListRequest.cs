namespace Openfort.SDK.Model
{
	public class SessionListRequest : BaseExpandableListRequest<SessionResponseExpandable>
	{
		public SessionListRequest(string player, int? limit = null, int? skip = null, SortOrder? order = null, List<SessionResponseExpandable>? expand = null) : base(limit, skip, order, expand)
		{
			Player = player;
		}

		public string Player { get; set; }
	}
}
