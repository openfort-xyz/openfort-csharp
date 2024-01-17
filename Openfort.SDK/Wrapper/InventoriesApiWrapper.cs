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

        public async Task<InventoryListResponse> GetPlayerNftInventory(PlayerInventoryListRequest request) => await apiClient.GetPlayerNftInventoryAsync(request.Id, request.ChainId, request.Limit, request.Skip, request.Order, request.ContractIds);

        public async Task<InventoryListResponse> GetAccountNftInventory(AccountInventoryListRequest request) => await apiClient.GetAccountNftInventoryAsync(request.Id, request.Limit, request.Skip, request.Order, request.ContractIds);

        public async Task<InventoryListResponse> GetPlayerCryptoCurrencyInventory(PlayerInventoryListRequest request) => await apiClient.GetPlayerCryptoCurrencyInventoryAsync(request.Id, request.ChainId, request.Limit, request.Skip, request.Order, request.ContractIds);

        public async Task<InventoryListResponse> GetAccountCryptoCurrencyInventory(AccountInventoryListRequest request) => await apiClient.GetAccountCryptoCurrencyInventoryAsync(request.Id, request.Limit, request.Skip, request.Order, request.ContractIds);

        public async Task<InventoryResponse> GetPlayerNativeInventory(PlayerInventoryRequest request) => await apiClient.GetPlayerNativeInventoryAsync(request.Id, request.ChainId);

        public async Task<InventoryResponse> GetAccountNativeInventory(AccountInventoryRequest request) => await apiClient.GetAccountNativeInventoryAsync(request.Id);
    }
}

