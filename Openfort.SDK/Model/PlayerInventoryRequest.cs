namespace Openfort.SDK.Model
{
	public class PlayerInventoryRequest
	{
		public PlayerInventoryRequest(string playerId, int chainId)
		{
            PlayerId = playerId;
			ChainId = chainId;
		}

		public string PlayerId { get; set; }

		public int ChainId { get; set; }
	}
}
