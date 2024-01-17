namespace Openfort.SDK.Model
{
	public class PlayerCreateAccountRequest : CreatePlayerAccountRequest
	{
		public PlayerCreateAccountRequest(string id, int chainId = default(int), string? externalOwnerAddress = null, DataAccountTypes? accountType = null, string tokenContract = null, long tokenId = default(long)) : base(chainId, externalOwnerAddress, accountType, tokenContract, tokenId)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

