namespace Openfort.SDK.Model
{
	public class TransactionIntentRequest : BaseGetRequest<TransactionIntentResponseExpandable>
	{
		public TransactionIntentRequest(string id, List<TransactionIntentResponseExpandable>? expand = null) : base(id, expand)
		{
		}
	}
}
