namespace Openfort.SDK.Model
{
	public class TransactionIntentListRequest : BaseExpandableListRequest<TransactionIntentResponseExpandable>
	{
		public TransactionIntentListRequest(
			int? limit = null,
			int? skip = null,
			SortOrder? order = null,
			List<TransactionIntentResponseExpandable>? expand = null,
			int? chainId = null,
			List<string>? accountIds = null,
			List<string>? playerIds = null,
			double? status = null,
			List<string>? policyIds = null) : base(limit, skip, order, expand)
		{
			ChainId = chainId;
			AccountIds = accountIds ?? new List<string>();
			PlayerIds = playerIds ?? new List<string>();
			Status = status;
			PolicyIds = policyIds ?? new List<string>();
		}

		public int? ChainId { get; set; }

		public List<string> AccountIds { get; set; }

		public List<string> PlayerIds { get; set; }
		public double? Status { get; set; }

		public List<string> PolicyIds { get; set; }
	}
}

