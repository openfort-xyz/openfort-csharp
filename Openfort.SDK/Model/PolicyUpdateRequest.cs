namespace Openfort.SDK.Model
{
	public class PolicyUpdateRequest: UpdatePolicyRequest
    {
		public PolicyUpdateRequest(string id, int chainId = default(int), string name = null, PolicyStrategyRequest strategy = null, bool deleted = false): base(name, chainId, strategy, deleted)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

