namespace Openfort.SDK.Model
{
	public class PlayerTransferAccountOwnershipRequest : PlayerTransferOwnershipRequest
	{
		public PlayerTransferAccountOwnershipRequest(string id, int chainId, string policy, string newOwnerAddress) : base(policy, chainId, newOwnerAddress)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

