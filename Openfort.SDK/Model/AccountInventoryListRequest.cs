namespace Openfort.SDK.Model
{
    public class AccountInventoryListRequest : BaseListRequest
    {
        public AccountInventoryListRequest(string id, int? limit = null, int? skip = null, SortOrder? order = null, List<string>? contractIds = null) : base(limit, skip, order)
        {
            Id = id;
            ContractIds = contractIds ?? new List<string>();
        }

        public string Id { get; set; }

        public List<string> ContractIds { get; set; }
    }
}
