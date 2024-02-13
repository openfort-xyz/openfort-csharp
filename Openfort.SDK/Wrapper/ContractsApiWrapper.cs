using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
    public class ContractsApiWrapper : BaseApiWrapper
    {
        private readonly ContractsApi apiClient;

        public ContractsApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new ContractsApi(Configuration);
        }

        public async Task<ContractResponse> Create(CreateContractRequest request) => await apiClient.CreateContractAsync(request);

        public async Task<ContractResponse> Update(ContractUpdateRequest request) => await apiClient.UpdateContractAsync(request.Id, request);

        public async Task<ContractDeleteResponse> Delete(string id) => await apiClient.DeleteContractAsync(id);

        public async Task<ContractResponse> Get(string id) => await apiClient.GetContractAsync(id);

        public async Task<ContractReadResponse> Read(ContractReadRequest request) => await apiClient.ReadContractAsync(request.Id, request.FunctionName, request.FunctionArgs);

        public async Task<ContractListResponse> List(ContractListRequest request)
        {
            return await apiClient.GetContractsAsync(request.Limit, request.Skip, request.Order, request.Name, request.Deleted, request.ChainId, request.Address);
        }
    }
}

