using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
	public class SettingsApiWrapper: BaseApiWrapper
	{
        private readonly SettingsApi apiClient;

        public SettingsApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new SettingsApi(Configuration);
        }

        public async Task<PaymasterDepositorListResponse> GetDepositorAddresses() => await apiClient.GetDepositorAddressesAsync();

        public async Task<PaymasterDepositorResponse> AddDepositorAddress(PaymasterDepositorCreateRequest request) => await apiClient.AddDepositorAddressAsync(request);

        public async Task<PaymasterDepositorDeleteResponse> RemoveDepositorAddress(string id) => await apiClient.RemoveDepositorAddressAsync(id);

        public async Task UpdateWebhook(string url) => await apiClient.UpdateWebhookAsync(new SettingsWebhookUpdateRequest(url));

        public async Task RemoveWebhook() => await apiClient.RemoveWebhookAsync();
    }
}

