using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
    public class AccountsApiWrapper: BaseApiWrapper
    {
        private readonly AccountsApi apiClient;

        public AccountsApiWrapper(string accessToken, string? basePath = null): base(accessToken, basePath)
        {
            apiClient = new AccountsApi(Configuration);
        }

        public async Task<AccountResponse> Create(CreateAccountRequest request) => await apiClient.CreateAccountAsync(request);

        public async Task<AccountResponse> Get(AccountGetRequest request) => await apiClient.GetAccountAsync(request.Id, request.Expand);

        public async Task<AccountListResponse> List(AccountListRequest request) => await apiClient.GetAccountsAsync(request.PlayerId, request.Limit, request.Skip, request.Order, request.Expand);

        public async Task<TransactionIntentResponse> RequestTransferOwnership(AccountTransferOwnershipRequest request) => await apiClient.RequestTransferOwnershipAsync(request.Id, request);

        public async Task<TransactionIntentResponse> CancelTransferOwnership(AccountCancelTransferOwnershipRequest request) => await apiClient.CancelTransferOwnershipAsync(request.Id, request);

        public async Task<SignPayloadResponse> SignPayload(AccountSignPayloadRequest request) => await apiClient.SignPayloadAsync(request.Id, request);

        public async Task<AccountResponse> Sync(string id) => await apiClient.SyncAccountAsync(id);
        public async Task<AccountResponse> Deploy(AccountDeployRequest request) => await apiClient.DeployAccountAsync(request.Id, request);

        public async Task<TransactionIntentResponse> StartRecovery(AccountStartRecoveryRequest request) => await apiClient.StartRecoveryAsync(request.Id, request);

        public async Task<TransactionIntentResponse> CompleteRecovery(AccountCompleteRecoveryRequest request) => await apiClient.CompleteRecoveryAsync(request.Id, request);
    }
}

