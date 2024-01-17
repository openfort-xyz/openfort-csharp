namespace Openfort.SDK.Model
{
	public class PlayerRevokeSessionRequest : RevokeSessionPlayerRequest
	{
		public PlayerRevokeSessionRequest(string id, string address, int chainId, string policy = null, bool optimistic = false) : base(address, policy, optimistic, chainId)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

