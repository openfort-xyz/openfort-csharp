using Openfort.SDK.Api;
using Openfort.SDK.Model;
using Openfort.SDK.Wrapper;

public class PolicyRulesApiWrapper : BaseApiWrapper
{
    private readonly PolicyRulesApi apiClient;

    public PolicyRulesApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
    {
        apiClient = new PolicyRulesApi(Configuration);
    }

    public async Task<PolicyRuleResponse> Create(CreatePolicyRuleRequest request) => await apiClient.CreatePolicyRulesAsync(request);

    public async Task<PolicyRuleListResponse> List(PolicyRuleListRequest request) => await apiClient.GetPolicyRulesAsync(request.PolicyId, request.Limit, request.Skip, request.Order, request.Expand);

    public async Task<PolicyRuleResponse> Update(PolicyRuleUpdateRequest request) => await apiClient.UpdatePolicyRulesAsync(request.Id, request);

    public async Task<PolicyRuleDeleteResponse> Delete(string id) => await apiClient.DeletePolicyRulesAsync(id);
}