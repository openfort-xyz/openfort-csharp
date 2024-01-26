using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
    public class NotificationsApiWrapper : BaseApiWrapper
    {
        private readonly NotificationsApi apiClient;

        public NotificationsApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new NotificationsApi(Configuration);
        }

        public async Task<NotificationResponse> Create(CreateNotificationRequest request) => await apiClient.CreateNotificationAsync(request);

        public async Task<NotificationResponse> Get(NotificationRequest request) => await apiClient.GetNotificationAsync(request.Id, request.Expand);

        public async Task<NotificationDeleteResponse> Delete(string id) => await apiClient.DeleteNotificationAsync(id);

        public async Task<NotificationListResponse> List(NotificationListRequest? request = null) => await apiClient.GetNotificationsAsync(request?.Limit, request?.Skip, request?.Order, request?.Expand, request?.Deleted, request?.Name);
    }
}

