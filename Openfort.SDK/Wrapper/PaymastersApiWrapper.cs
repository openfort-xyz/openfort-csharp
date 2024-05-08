using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
    public class PaymastersApiWrapper : BaseApiWrapper
    {
        private readonly PaymasterApi apiClient;

        public PaymastersApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new PaymasterApi(Configuration);
        }

        public async Task<PaymasterResponse> Create(CreatePaymasterRequest request) => await apiClient.CreatePaymasterAsync(request);

        public async Task<PaymasterResponse> Get(NotificationRequest request) => await apiClient.GetPaymasterAsync(request.Id);

        public async Task<PaymasterDeleteResponse> Delete(string id) => await apiClient.DeletePaymasterAsync(id);
    }
}

