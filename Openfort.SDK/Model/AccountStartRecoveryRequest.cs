namespace Openfort.SDK.Model
{
	public class AccountStartRecoveryRequest: StartRecoveryRequest
    {
		public AccountStartRecoveryRequest(string id, string newOwnerAddress, string policy): base(newOwnerAddress, policy)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

