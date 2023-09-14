namespace Openfort.SDK.Model
{
	public class AccountCompleteRecoveryRequest: CompleteRecoveryRequest
    {
		public AccountCompleteRecoveryRequest(string id, string newOwnerAddress, List<string> signatures, string policy): base(newOwnerAddress, signatures, policy)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

