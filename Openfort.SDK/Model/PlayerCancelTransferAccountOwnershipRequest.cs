namespace Openfort.SDK.Model
{
	public class PlayerCancelTransferAccountOwnershipRequest : PlayerCancelTransferOwnershipRequest
	{
		public PlayerCancelTransferAccountOwnershipRequest(string id, int chainId, string policy) : base(policy, chainId)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

