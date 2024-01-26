using Openfort.SDK.Api;
using Openfort.SDK.Model;
using Openfort.SDK.Wrapper;

public class NotificationSubscriptionsApiWrapper : BaseApiWrapper
{
    private readonly NotificationSubscriptionsApi apiClient;

    public NotificationSubscriptionsApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
    {
        apiClient = new NotificationSubscriptionsApi(Configuration);
    }

    public async Task<NotificationSubscription> Create(CreateNotificationSubscriptionRequest request) => await apiClient.CreateNotificationSubscriptionAsync(request);

    public async Task<NotificationSubscriptionListResponse> List(NotificationSubscriptionListRequest request) => await apiClient.GetNotificationSubscriptionsAsync(request.Id, request.Limit, request.Skip, request.Order);

    public async Task<NotificationSubscription> Get(string id) => await apiClient.GetNotificationSubscriptionAsync(id);

    public async Task<NotificationSubscriptionDeleteResponse> Delete(string id) => await apiClient.DeleteNotificationSubscriptionAsync(id);
}