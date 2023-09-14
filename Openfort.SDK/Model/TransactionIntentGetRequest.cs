namespace Openfort.SDK.Model
{
	public class TransactionIntentGetRequest: BaseGetRequest<TransactionIntentResponseExpandable>
	{
		public TransactionIntentGetRequest(string id, List<TransactionIntentResponseExpandable>? expand = null): base(id, expand)
		{
		}
	}
}
