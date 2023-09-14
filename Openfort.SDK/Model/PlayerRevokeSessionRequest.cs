namespace Openfort.SDK.Model
{
	public class PlayerRevokeSessionRequest: RevokeSessionPlayerRequest
    {
		public PlayerRevokeSessionRequest(string playerId, string address, int chainId, string policy = null, bool optimistic = false): base(address, policy, optimistic, chainId)
		{
			PlayerId = playerId;
		}

		public string PlayerId { get; set; }
	}
}

