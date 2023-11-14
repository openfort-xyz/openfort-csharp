using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
	public class Web3ConnectionsApiWrapper: BaseApiWrapper
	{
        private readonly Web3ConnectionsApi apiClient;

        public Web3ConnectionsApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new Web3ConnectionsApi(Configuration);
        }

        public async Task<Web3ActionListResponse> GetWeb3Actions(Web3ActionsListRequest request) => await apiClient.GetWeb3ActionsAsync(request.Id);

        public async Task<Web3ConnectionResponse> Create(CreateWeb3ConnectionRequest request) => await apiClient.CreateWeb3ConnectionAsync(request);

        public async Task<Web3ConnectionResponse> Get(Web3ConnectionGetRequest request) => await apiClient.GetWeb3ConnectionAsync(request.Id, request.Expand);

        public async Task<Web3ConnectionListResponse> List(Web3ConnectionListQueries request) => await apiClient.GetWeb3ConnectionsAsync(request.Player, request.Limit, request.Skip, request.Order, request.Disconnected);

        public async Task<Web3ActionResponse> SubmitWeb3Action(Web3ActionSubmit request) => await apiClient.SubmitWeb3ActionAsync(request.Id, request.Web3Action, request.SubmitWeb3ActionRequest);
    }
}

