namespace Openfort.SDK.Model
{
	public class ContractListRequest: BaseListRequest
	{
		public ContractListRequest(int? limit = null, int? skip = null, SortOrder? order = null, string name = null, bool? deleted = null, int? chainId = null, string address = null): base(limit, skip, order)
		{
			Name = name;
			Deleted = deleted;
			ChainId = chainId;
			Address = address;
		}

		public string Name { get; set; }

		public bool? Deleted { get; set; }

		public int? ChainId { get; set; }

		public string Address { get; set; }
	}
}

