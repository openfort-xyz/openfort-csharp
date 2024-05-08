using Openfort.SDK.Api;
using Openfort.SDK.Model;
using Shield.SDK;
using Shield.SDK.Models;

namespace Openfort.SDK.Wrapper
{
    public class IamApiWrapper : BaseApiWrapper
    {
        private readonly AdminAuthenticationApi apiClient;

        public IamApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new AdminAuthenticationApi(Configuration);
        }

        public async Task<AuthPlayerResponse> CreateAuthPlayer(CreateAuthPlayerRequest request, PreGenerateEmbeddedAccountsConfiguration? embeddedRequest)
        {
            AuthPlayerResponseWithRecoveryShare authPlayerResponseWithRecoveryShare = await apiClient.CreateAuthPlayerAsync(request);
            if (authPlayerResponseWithRecoveryShare.RecoveryShare != null)
            {
                ShieldAuthProvider authProvider;
                if (embeddedRequest.ShieldAuthProvider == ShieldAuthProvider.Openfort)
                {
                    authProvider = ShieldAuthProvider.Openfort;
                }
                else if (embeddedRequest.ShieldAuthProvider == ShieldAuthProvider.Custom)
                {
                    authProvider = ShieldAuthProvider.Custom;
                }
                else
                {
                    throw new Exception("Invalid ShieldAuthProvider");
                }

                ShieldAuthOptions authOptions = new ShieldAuthOptions
                {
                    AuthProvider = (Shield.SDK.Enums.ShieldAuthProvider)authProvider,
                    EncryptionPart = embeddedRequest.EncryptionPart,
                    ExternalUserId = request.ThirdPartyUserId,
                    ApiKey = embeddedRequest.ApiKey,
                    ApiSecret = embeddedRequest.ApiSecret,
                };
                Share share = new Share
                {
                    Secret = authPlayerResponseWithRecoveryShare.RecoveryShare,
                    Entropy = !string.IsNullOrEmpty(embeddedRequest.EncryptionPart) ? Entropy.PROJECT : Entropy.NONE,
                };
                ShieldOptions shieldOptions = new ShieldOptions
                {
                    ApiKey = embeddedRequest.ApiKey,
                };

                ShieldClient shieldSDK = new ShieldClient(shieldOptions);
                await shieldSDK.PreRegister(share, authOptions);
            }

            authPlayerResponseWithRecoveryShare.RecoveryShare = null;
            return (AuthPlayerResponse)authPlayerResponseWithRecoveryShare;
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
