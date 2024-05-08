using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
    public class ExchangeApiWrapper : BaseApiWrapper
    {
        private readonly ExchangeApi apiClient;

        public ExchangeApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new ExchangeApi(Configuration);
        }

        public async Task<TransactionIntentResponse> Create(CreateExchangeRequest request) => await apiClient.CreateSwapAsync(request);

        public async Task<QuoteExchangeResult> Get(CreateExchangeRequest request) => await apiClient.QuoteSwapAsync(request);
    }
}

