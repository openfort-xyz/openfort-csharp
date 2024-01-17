using System;
namespace Openfort.SDK.Model
{
	public class AccountListRequest : BaseExpandableListRequest<AccountResponseExpandable>
	{
		public AccountListRequest(string player, int? limit = null, int? skip = null, SortOrder? order = null, List<AccountResponseExpandable>? expand = null) : base(limit, skip, order, expand)
		{
			Player = player;
		}

		public string Player { get; set; }
	}
}

