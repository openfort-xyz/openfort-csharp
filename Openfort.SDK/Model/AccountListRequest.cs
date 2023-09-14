using System;
namespace Openfort.SDK.Model
{
	public class AccountListRequest: BaseExpandableListRequest<AccountResponseExpandable>
	{
		public AccountListRequest(string playerId, int? limit = null, int? skip = null, SortOrder? order = null, List<AccountResponseExpandable>? expand = null): base(limit, skip, order, expand)
		{
			PlayerId = playerId;
		}

        public string PlayerId { get; set; }
	}
}

