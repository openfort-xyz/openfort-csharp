using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
    public class IamApiWrapper: BaseApiWrapper
    {
        private readonly AuthenticationApi apiClient;

        public IamApiWrapper(string accessToken, string? basePath = null): base(accessToken, basePath)
        {
            apiClient = new AuthenticationApi(Configuration);
        }

        public async Task<PlayerResponse> VerifyToken(string token) => await apiClient.VerifyAuthTokenAsync(token);
    }
}
