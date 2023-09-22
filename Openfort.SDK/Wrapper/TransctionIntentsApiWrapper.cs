using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
	public class TransactionIntentsApiWrapper: BaseApiWrapper
	{
        private readonly TransactionIntentsApi apiClient;

        public TransactionIntentsApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new TransactionIntentsApi(Configuration);
        }

        public async Task<EstimateTransactionIntentGasResult> EstimateCost(CreateTransactionIntentRequest request) => await apiClient.EstimateTransactionIntentCostAsync(request);

        public async Task<TransactionIntentResponse> Create(CreateTransactionIntentRequest request) => await apiClient.CreateTransactionIntentAsync(request);

        public async Task<TransactionIntentResponse> Get(TransactionIntentGetRequest request) => await apiClient.GetTransactionIntentAsync(request.Id, request.Expand);

        public async Task<TransactionIntentListResponse> List(TransactionIntentListRequest request) => await apiClient.GetTransactionIntentsAsync(request.Limit, request.Skip, request.Order, request.Expand, request.ChainId, request.AccountIds, request.PlayerIds, request.PolicyIds);

        public async Task<TransactionIntentResponse> Signature(SessionSignatureRequest request) => await apiClient.SignatureAsync(request.Id, request);
    }
}

