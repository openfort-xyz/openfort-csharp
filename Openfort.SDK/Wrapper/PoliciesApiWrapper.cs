using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
	public class PoliciesApiWrapper : BaseApiWrapper
	{
        private readonly PoliciesApi apiClient;

        public PoliciesApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new PoliciesApi(Configuration);
        }

        public async Task<PolicyResponse> Create(CreatePolicyRequest request) => await apiClient.CreatePolicyAsync(request);

        public async Task<PolicyResponse> Get(PolicyGetRequest request) => await apiClient.GetPolicyAsync(request.Id, request.Expand);

        public async Task<PolicyResponse> Update(PolicyUpdateRequest request) => await apiClient.UpdatePolicyAsync(request.Id, request);

        public async Task<PolicyDeleteResponse> Delete(string id) => await apiClient.DeletePolicyAsync(id);

        public async Task<PolicyListResponse> List(PolicyListRequest request) => await apiClient.GetPoliciesAsync(request.Limit, request.Skip, request.Order, request.Expand, request.Name, request.Deleted, request.ChainId);

        public async Task<PolicyRuleResponse> CreateRule(PolicyCreateRuleRequest request) => await apiClient.CreatePolicyAllowFunctionAsync(request.PolicyId, request);

        public async Task<PolicyRuleListResponse> GetRule(PolicyGetRulesRequest request) => await apiClient.GetPolicyAllowFunctionsAsync(request.Id, request.Expand);

        public async Task<PolicyRuleResponse> UpdateRule(PolicyUpdateRuleRequest request) => await apiClient.UpdatePolicyAllowFunctionAsync(request.PolicyId, request.RuleId, request);
    }
}

