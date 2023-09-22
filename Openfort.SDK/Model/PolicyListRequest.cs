namespace Openfort.SDK.Model
{
	public class PolicyListRequest: BaseExpandableListRequest<PolicyResponseExpandable>
	{
		public PolicyListRequest(int? limit = null, int? skip = null, SortOrder? order = null, List<PolicyResponseExpandable>? expand = null, string? name = null, bool? deleted = null, int? chainId = null): base(limit, skip, order, expand)
		{
			Name = name;
			Deleted = deleted;
			ChainId = chainId;
		}

		public string? Name { get; set; }

		public bool? Deleted { get; set; }

		public int? ChainId { get; set; }
	}
}
