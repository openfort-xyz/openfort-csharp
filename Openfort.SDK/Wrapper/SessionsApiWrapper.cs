using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
	public class SessionsApiWrapper: BaseApiWrapper
	{
        private readonly SessionsApi apiClient;

        public SessionsApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new SessionsApi(Configuration);
        }

        public async Task<SessionResponse> Create(CreateSessionRequest request) => await apiClient.CreateSessionAsync(request);

        public async Task<SessionListResponse> List(SessionListRequest request) => await apiClient.GetPlayerSessionsAsync(request.PlayerId, request.Limit, request.Skip, request.Order, request.Expand);

        public async Task<SessionResponse> Get(SessionGetRequest request) => await apiClient.GetSessionAsync(request.Id, request.Expand);

        public async Task<SessionResponse> Revoke(RevokeSessionRequest request) => await apiClient.RevokeSessionAsync(request);

        public async Task<SessionResponse> Signature(SessionSignatureRequest request) => await apiClient.SignatureSessionAsync(request.Id, request);
    }
}

