namespace Openfort.SDK.Model
{
	public class AccountTransferOwnershipRequest: TransferOwnershipRequest
    {
		public AccountTransferOwnershipRequest(string id, string newOwnerAddress, string policy): base(newOwnerAddress, policy) 
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

