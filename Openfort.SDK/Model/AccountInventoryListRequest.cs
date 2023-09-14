namespace Openfort.SDK.Model
{
    public class AccountInventoryListRequest : BaseListRequest
    {
        public AccountInventoryListRequest(string accountId, int? limit = null, int? skip = null, SortOrder? order = null, List<string>? contractIds = null) : base(limit, skip, order)
        {
            AccountId = accountId;
            ContractIds = contractIds ?? new List<string>();
        }

        public string AccountId { get; set; }

        public List<string> ContractIds { get; set; }
    }
}
