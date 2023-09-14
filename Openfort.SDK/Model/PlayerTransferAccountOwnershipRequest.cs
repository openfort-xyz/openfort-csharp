namespace Openfort.SDK.Model
{
	public class PlayerTransferAccountOwnershipRequest: PlayerTransferOwnershipRequest
    {
		public PlayerTransferAccountOwnershipRequest(string playerId, int chainId, string policy, string newOwnerAddress): base(policy, chainId, newOwnerAddress)
		{
			PlayerId = playerId;
		}

		public string PlayerId { get; set; }
	}
}

