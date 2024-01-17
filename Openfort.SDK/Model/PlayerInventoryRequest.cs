namespace Openfort.SDK.Model
{
	public class PlayerInventoryRequest
	{
		public PlayerInventoryRequest(string id, int chainId)
		{
			Id = id;
			ChainId = chainId;
		}

		public string Id { get; set; }

		public int ChainId { get; set; }
	}
}
