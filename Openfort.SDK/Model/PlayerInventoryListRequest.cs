namespace Openfort.SDK.Model
{
	public class PlayerInventoryListRequest: BaseListRequest
	{
		public PlayerInventoryListRequest(string playerId, int chainId, int? limit = null, int? skip = null, SortOrder? order = null, List<string>? contractIds = null): base(limit, skip, order)
		{
            PlayerId = playerId;
			ChainId = chainId;
			ContractIds = contractIds ?? new List<string>();
		}

		public string PlayerId { get; set; }

		public int ChainId { get; set; }

		public List<string> ContractIds { get; set; }
	}
}
