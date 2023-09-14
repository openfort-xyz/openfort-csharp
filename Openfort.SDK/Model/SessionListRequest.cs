namespace Openfort.SDK.Model
{
	public class SessionListRequest: BaseExpandableListRequest<SessionResponseExpandable>
	{
		public SessionListRequest(string playerId, int? limit = null, int? skip = null, SortOrder? order = null, List<SessionResponseExpandable>? expand = null): base(limit, skip, order, expand)
		{
			PlayerId = playerId;
		}

		public string PlayerId { get; set; }
	}
}
