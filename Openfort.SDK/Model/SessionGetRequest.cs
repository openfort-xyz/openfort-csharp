namespace Openfort.SDK.Model
{
	public class SessionGetRequest: BaseGetRequest<SessionResponseExpandable>
	{
		public SessionGetRequest(string id, List<SessionResponseExpandable>? expand = null): base(id, expand)
		{
		}
	}
}
