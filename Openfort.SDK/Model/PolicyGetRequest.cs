namespace Openfort.SDK.Model
{
	public class PolicyGetRequest: BaseGetRequest<PolicyResponseExpandable>
	{
		public PolicyGetRequest(string id, List<PolicyResponseExpandable>? expand = null): base(id, expand)
		{
		}
	}
}
