using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
    public class SettingsApiWrapper : BaseApiWrapper
    {
        private readonly SettingsApi apiClient;

        public SettingsApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new SettingsApi(Configuration);
        }

        public async Task<DeveloperAccountListResponse> GetDeveloperAccounts() => await apiClient.GetDeveloperAccountsAsync();

        public async Task<DeveloperAccountResponse> CreateDepositorAddress(DeveloperAccountCreateRequest request) => await apiClient.CreateDeveloperAccountAsync(request);

        public async Task<DeveloperAccountGetMessageResponse> GetVerificationPayload(string address) => await apiClient.GetVerificationPayloadAsync(address);

        public async Task<DeveloperAccountDeleteResponse> DeleteDepositorAddress(string id) => await apiClient.DeleteDeveloperAccountAsync(id);

        public async Task UpdateWebhook(string url) => await apiClient.UpdateWebhookAsync(new SettingsWebhookUpdateRequest(url));

        public async Task RemoveWebhook() => await apiClient.RemoveWebhookAsync();
    }
}

