using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
    public class OAuthApiWrapper : BaseApiWrapper
    {
        private readonly OAuthApi apiClient;

        public OAuthApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new OAuthApi(Configuration);
        }

        public async Task<PlayerResponse> GetPlayerByExternalId(GetPlayerByExternalIdRequest request) => await apiClient.GetPlayerByExternalIdAsync(request.Provider, request.ExternalUserId);

        public async Task<PlayerResponse> VerifyOAuthToken(VerifyOAuthTokenRequest request) => await apiClient.VerifyOAuthTokenAsync(request.Provider, request);
    }
}
