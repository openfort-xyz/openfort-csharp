namespace Openfort.SDK.Model
{
	public class AccountGetRequest : BaseGetRequest<AccountResponseExpandable>
    {
		public AccountGetRequest(string id, List<AccountResponseExpandable>? expand = null): base(id, expand)
		{
        }
    }
}

