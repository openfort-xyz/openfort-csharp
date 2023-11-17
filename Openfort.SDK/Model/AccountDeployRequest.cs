namespace Openfort.SDK.Model
{
	public class AccountDeployRequest: DeployRequest
    {
		public AccountDeployRequest(string id, string policy): base(policy)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

