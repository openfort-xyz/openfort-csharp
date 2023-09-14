namespace Openfort.SDK.Model
{
	public class PolicyRuleUpdateRequest: UpdatePolicyRuleRequest
    {
		public PolicyRuleUpdateRequest(string id, PolicyRuleType type, string functionName = null, string contract = null, string gasLimit = null, int countLimit = default(int), TimeIntervalType? timeIntervalType = null, int timeIntervalValue = default(int)): base(type, functionName, contract, gasLimit, countLimit, timeIntervalType, timeIntervalValue)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

