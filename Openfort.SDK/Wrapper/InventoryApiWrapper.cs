using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
	public class InventoryApiWrapper : BaseApiWrapper
	{
        private readonly InventoryApi apiClient;

        public InventoryApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new InventoryApi(Configuration);
        }

        public async Task<InventoryListResponse> GetPlayerNftInventory(PlayerInventoryListRequest request) => await apiClient.GetPlayerNftInventoryAsync(request.PlayerId, request.ChainId, request.Limit, request.Skip, request.Order, request.ContractIds);

        public async Task<InventoryListResponse> GetAccountNftInventory(AccountInventoryListRequest request) => await apiClient.GetAccountNftInventoryAsync(request.AccountId, request.Limit, request.Skip, request.Order, request.ContractIds);

        public async Task<InventoryListResponse> GetPlayerCryptoCurrencyInventory(PlayerInventoryListRequest request) => await apiClient.GetPlayerCryptoCurrencyInventoryAsync(request.PlayerId, request.ChainId, request.Limit, request.Skip, request.Order, request.ContractIds);

        public async Task<InventoryListResponse> GetAccountCryptoCurrencyInventory(AccountInventoryListRequest request) => await apiClient.GetAccountCryptoCurrencyInventoryAsync(request.AccountId, request.Limit, request.Skip, request.Order, request.ContractIds);

        public async Task<InventoryResponse> GetPlayerNativeInventory(PlayerInventoryRequest request) => await apiClient.GetPlayerNativeInventoryAsync(request.PlayerId, request.ChainId);

        public async Task<InventoryResponse> GetAccountNativeInventory(AccountInventoryRequest request) => await apiClient.GetAccountNativeInventoryAsync(request.AccountId);
    }
}

