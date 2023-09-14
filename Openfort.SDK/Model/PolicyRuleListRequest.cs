namespace Openfort.SDK.Model
{
	public class PolicyRuleListRequest: BaseExpandableListRequest<string>
	{
		public PolicyRuleListRequest(string policyId, int? limit = null, int? skip = null, SortOrder? order = null, List<string>? expand = null): base(limit, skip, order, expand)
		{
			PolicyId = policyId;
		}

		public string PolicyId { get; set; }
	}
}
