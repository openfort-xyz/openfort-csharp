using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
    public class IamApiWrapper : BaseApiWrapper
    {
        private readonly AdminAuthenticationApi apiClient;

        public IamApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new AdminAuthenticationApi(Configuration);
        }

        public async Task<AuthSessionResponse> VerifyAuthToken(string token) => await apiClient.VerifyAuthTokenAsync(token);

        public async Task<PlayerResponse> VerifyOAuthToken(AuthenticateOAuthRequest request) => await apiClient.VerifyOAuthTokenAsync(request);

        public async Task<OAuthConfig> CreateOAuthConfig(OAuthConfig request) => await apiClient.CreateOAuthConfigAsync(request);

        public async Task<AuthPlayerResponse> DeleteAuthPlayer(string id) => await apiClient.DeleteAuthPlayerAsync(id);

        public async Task DeleteOAuthConfigAsync(OAuthProvider request) => await apiClient.DeleteOAuthConfigAsync(request);

        public async Task<AuthPlayerListResponse> GetAuthPlayers(AuthPlayerListQueries request) => await apiClient.GetAuthPlayersAsync(request.Limit, request.Skip, request.Order);

        public async Task<OAuthConfig> GetOAuthConfig(OAuthProvider request) => await apiClient.GetOAuthConfigAsync(request);

        public async Task<OAuthConfigListResponse> ListOAuthConfig(string token) => await apiClient.ListOAuthConfigAsync();

    }
}
