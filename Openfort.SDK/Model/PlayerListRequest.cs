namespace Openfort.SDK.Model
{
	public class PlayerListRequest: BaseExpandableListRequest<PlayerResponseExpandable>
	{
		public PlayerListRequest(int? limit = null, int? skip = null, SortOrder? order = null, List<PlayerResponseExpandable> expand = null, string name = null): base(limit, skip, order, expand)
		{
			Name = name;
		}

		public string Name { get; set; }
	}
}

