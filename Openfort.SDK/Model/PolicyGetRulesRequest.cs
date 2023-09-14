namespace Openfort.SDK.Model
{
	public class PolicyGetRulesRequest: BaseGetRequest<string>
	{
		public PolicyGetRulesRequest(string id, List<string>? expand = null): base(id, expand)
		{
		}
	}
}
