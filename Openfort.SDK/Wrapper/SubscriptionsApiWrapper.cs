using Openfort.SDK.Api;
using Openfort.SDK.Model;
using Openfort.SDK.Wrapper;

public class SubscriptionsApiWrapper : BaseApiWrapper
{
    private readonly SubscriptionsApi apiClient;

    public SubscriptionsApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
    {
        apiClient = new SubscriptionsApi(Configuration);
    }

    public async Task<SubscriptionResponse> Create(CreateSubscriptionRequest request) => await apiClient.CreateSubscriptionAsync(request);

    public async Task<SubscriptionListResponse> List() => await apiClient.GetSubscriptionsAsync();

    public async Task<SubscriptionResponse> Get(string id) => await apiClient.GetSubscriptionAsync(id);

    public async Task<SubscriptionDeleteResponse> Delete(string id) => await apiClient.DeleteSubscriptionAsync(id);
}