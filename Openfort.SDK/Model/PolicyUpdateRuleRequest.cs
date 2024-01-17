namespace Openfort.SDK.Model
{
    public class PolicyUpdateRuleRequest : UpdatePolicyRuleRequest
    {
        public PolicyUpdateRuleRequest(string policy, string policyRule, PolicyRuleType ruleType, string? functionName = null, string? contract = null, string? gasLimit = null, int? countLimit = null, TimeIntervalType? timeIntervalType = null, int? timeIntervalValue = null) : base(ruleType, functionName, contract, gasLimit, countLimit ?? 0, timeIntervalType, timeIntervalValue ?? 0)
        {
            Policy = policy;
            PolicyRule = policyRule;
        }

        public string Policy { get; set; }

        public string PolicyRule { get; set; }
    }
}
