namespace Openfort.SDK.Model
{
	public class PlayerInventoryListRequest : BaseListRequest
	{
		public PlayerInventoryListRequest(string id, int chainId, int? limit = null, int? skip = null, SortOrder? order = null, List<string>? contractIds = null) : base(limit, skip, order)
		{
			Id = id;
			ChainId = chainId;
			ContractIds = contractIds ?? new List<string>();
		}

		public string Id { get; set; }

		public int ChainId { get; set; }

		public List<string> ContractIds { get; set; }
	}
}
