namespace Openfort.SDK.Model
{
	public class PolicyRuleListRequest : BaseExpandableListRequest<string>
	{
		public PolicyRuleListRequest(string id, int? limit = null, int? skip = null, SortOrder? order = null, List<string>? expand = null) : base(limit, skip, order, expand)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}
