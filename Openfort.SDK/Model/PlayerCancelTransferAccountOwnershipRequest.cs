namespace Openfort.SDK.Model
{
	public class PlayerCancelTransferAccountOwnershipRequest: PlayerCancelTransferOwnershipRequest
    {
		public PlayerCancelTransferAccountOwnershipRequest(string playerId, int chainId, string policy): base(policy, chainId)
		{
			PlayerId = playerId;
		}

		public string PlayerId { get; set; }
	}
}

