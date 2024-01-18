namespace Openfort.SDK.Model
{
    public class AccountRequest : BaseGetRequest<AccountResponseExpandable>
    {
        public AccountRequest(string id, List<AccountResponseExpandable>? expand = null) : base(id, expand)
        {
        }
    }
}

