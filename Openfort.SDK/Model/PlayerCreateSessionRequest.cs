namespace Openfort.SDK.Model
{
	public class PlayerCreateSessionRequest : CreatePlayerSessionRequest
	{
		public PlayerCreateSessionRequest(string id, string address, int chainId, int validAfter, int validUntil, string externalOwnerAddress = null, int limit = default(int), bool optimistic = false, string policy = null, List<string> whitelist = default(List<string>)) : base(address, chainId, externalOwnerAddress, limit, optimistic, policy, validAfter, validUntil, whitelist)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

