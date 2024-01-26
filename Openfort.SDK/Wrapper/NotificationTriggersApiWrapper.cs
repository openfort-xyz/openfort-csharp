using Openfort.SDK.Api;
using Openfort.SDK.Model;
using Openfort.SDK.Wrapper;

public class NotificationTriggersApiWrapper : BaseApiWrapper
{
    private readonly NotificationTriggersApi apiClient;

    public NotificationTriggersApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
    {
        apiClient = new NotificationTriggersApi(Configuration);
    }

    public async Task<NotificationTriggerResponse> Create(CreateNotificationTriggerRequest request) => await apiClient.CreateNotificationTriggerAsync(request);

    public async Task<NotificationTriggerListResponse> List(NotificationTriggerListRequest request) => await apiClient.GetNotificationTriggersAsync(request.Id, request.Limit, request.Skip, request.Order);

    public async Task<NotificationTriggerResponse> Get(string id) => await apiClient.GetNotificationTriggerAsync(id);

    public async Task<NotificationTriggerDeleteResponse> Delete(string id) => await apiClient.DeleteNotificationTriggerAsync(id);
}