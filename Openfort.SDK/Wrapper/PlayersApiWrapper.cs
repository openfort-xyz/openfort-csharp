using Openfort.SDK.Api;
using Openfort.SDK.Model;

namespace Openfort.SDK.Wrapper
{
    public class PlayersApiWrapper : BaseApiWrapper
    {
        private readonly PlayersApi apiClient;

        public PlayersApiWrapper(string accessToken, string? basePath = null) : base(accessToken, basePath)
        {
            apiClient = new PlayersApi(Configuration);
        }

        public async Task<PlayerResponse> Get(PlayerRequest request) => await apiClient.GetPlayerAsync(request.Id, request.Expand);

        public async Task<PlayerListResponse> List(PlayerListRequest? request = null)
        {
            return await apiClient.GetPlayersAsync(request?.Limit, request?.Skip, request?.Order, request?.Expand, request?.Name);
        }

        public async Task<PlayerResponse> Create(PlayerCreateRequest request) => await apiClient.CreatePlayerAsync(request);

        public async Task<PlayerResponse> Update(UpdatePlayerRequest request) => await apiClient.UpdatePlayerAsync(request.Id, request);

        public async Task<PlayerDeleteResponse> Delete(string id) => await apiClient.DeletePlayerAsync(id);

        public async Task<TransactionIntentResponse> RequestTransferAccountOwnership(PlayerTransferAccountOwnershipRequest request) => await apiClient.RequestTransferAccountOwnershipAsync(request.Id, request);

        public async Task<TransactionIntentResponse> CancelTransferAccountOwnership(PlayerCancelTransferAccountOwnershipRequest request) => await apiClient.CancelTransferAccountOwnershipAsync(request.Id, request);
    }
}

