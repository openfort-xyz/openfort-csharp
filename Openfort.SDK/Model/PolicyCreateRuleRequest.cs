namespace Openfort.SDK.Model
{
	public class PolicyCreateRuleRequest: CreatePolicyAllowFunctionRequest
    {
		public PolicyCreateRuleRequest(string policyId, PolicyRuleType ruleType, string functionName = null, string contract = null, string gasLimit = null, int? countLimit = null, TimeIntervalType? timeIntervalType = null, int? timeIntervalValue = null): base (ruleType, functionName, contract, gasLimit, countLimit ?? 0, timeIntervalType, timeIntervalValue ?? 0)
		{
			PolicyId = policyId;
		}

		public string PolicyId { get; set; }
	}
}
