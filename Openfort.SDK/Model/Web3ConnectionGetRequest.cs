namespace Openfort.SDK.Model
{
	public class Web3ConnectionGetRequest: BaseGetRequest<Web3ConnectionResponseExpandable>
	{
		public Web3ConnectionGetRequest(string id, List<Web3ConnectionResponseExpandable>? expand = null): base(id, expand)
		{
		}
	}
}
