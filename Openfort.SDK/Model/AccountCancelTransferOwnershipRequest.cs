using System;
namespace Openfort.SDK.Model
{
	public class AccountCancelTransferOwnershipRequest: CancelTransferOwnershipRequest
    {
		public AccountCancelTransferOwnershipRequest(string id, string policy): base(policy)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

