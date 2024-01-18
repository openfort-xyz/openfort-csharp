namespace Openfort.SDK.Model
{
	public class Web3ConnectionRequest : BaseGetRequest<Web3ConnectionResponseExpandable>
	{
		public Web3ConnectionRequest(string id, List<Web3ConnectionResponseExpandable>? expand = null) : base(id, expand)
		{
		}
	}
}
