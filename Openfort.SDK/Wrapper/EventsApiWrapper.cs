using Openfort.SDK.Api;
using Openfort.SDK.Model;
using Openfort.SDK.Wrapper;

public class EventsApiWrapper : BaseApiWrapper
{
    private readonly EventsApi apiClient;

    public EventsApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
    {
        apiClient = new EventsApi(Configuration);
    }

    public async Task<EventResponse> Create(CreateEventRequest request) => await apiClient.CreateEventAsync(request);

    public async Task<EventListResponse> List(EventListQueries request) => await apiClient.GetEventsAsync(request.Limit, request.Skip, request.Order);

    public async Task<EventResponse> Get(string id) => await apiClient.GetEventAsync(id);

    public async Task<EventDeleteResponse> Delete(string id) => await apiClient.DeleteEventAsync(id);
}