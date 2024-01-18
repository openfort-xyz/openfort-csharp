using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
    public class InventoriesApiWrapper : BaseApiWrapper
    {
        private readonly InventoriesApi apiClient;

        public InventoriesApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new InventoriesApi(Configuration);
        }

        public async Task<InventoryListResponse> GetPlayerNft(PlayerInventoryListRequest request) => await apiClient.GetPlayerNftInventoryAsync(request.Id, request.ChainId, request.Limit, request.Skip, request.Order, request.ContractIds);

        public async Task<InventoryListResponse> GetAccountNft(AccountInventoryListRequest request) => await apiClient.GetAccountNftInventoryAsync(request.Id, request.Limit, request.Skip, request.Order, request.ContractIds);

        public async Task<InventoryListResponse> GetPlayerCryptoCurrency(PlayerInventoryListRequest request) => await apiClient.GetPlayerCryptoCurrencyInventoryAsync(request.Id, request.ChainId, request.Limit, request.Skip, request.Order, request.ContractIds);

        public async Task<InventoryListResponse> GetAccountCryptoCurrency(AccountInventoryListRequest request) => await apiClient.GetAccountCryptoCurrencyInventoryAsync(request.Id, request.Limit, request.Skip, request.Order, request.ContractIds);

        public async Task<InventoryResponse> GetPlayerNative(PlayerInventoryRequest request) => await apiClient.GetPlayerNativeInventoryAsync(request.Id, request.ChainId);

        public async Task<InventoryResponse> GetAccountNative(AccountInventoryRequest request) => await apiClient.GetAccountNativeInventoryAsync(request.Id);
    }
}

