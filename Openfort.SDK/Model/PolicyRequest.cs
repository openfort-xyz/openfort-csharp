namespace Openfort.SDK.Model
{
	public class PolicyRequest : BaseGetRequest<PolicyResponseExpandable>
	{
		public PolicyRequest(string id, List<PolicyResponseExpandable>? expand = null) : base(id, expand)
		{
		}
	}
}
