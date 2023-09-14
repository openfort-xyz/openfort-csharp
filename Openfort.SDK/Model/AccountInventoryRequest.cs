namespace Openfort.SDK.Model
{
    public class AccountInventoryRequest
    {
        public AccountInventoryRequest(string accountId)
        {
            AccountId = accountId;
        }

        public string AccountId { get; set; }
    }
}
