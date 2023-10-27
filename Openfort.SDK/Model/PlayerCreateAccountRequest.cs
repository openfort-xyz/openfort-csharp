namespace Openfort.SDK.Model
{
	public class PlayerCreateAccountRequest: CreatePlayerAccountRequest
    {
		public PlayerCreateAccountRequest(string playerId, int chainId = default(int), string externalOwnerAddress = null, DataAccountTypes? accountType = null, string tokenContract = null, long tokenId = default(long)): base(chainId, externalOwnerAddress, accountType, tokenContract, tokenId)
		{
			PlayerId = playerId;
		}

		public string PlayerId { get; set; }
	}
}

