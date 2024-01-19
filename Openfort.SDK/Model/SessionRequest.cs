namespace Openfort.SDK.Model
{
	public class SessionRequest : BaseGetRequest<SessionResponseExpandable>
	{
		public SessionRequest(string id, List<SessionResponseExpandable>? expand = null) : base(id, expand)
		{
		}
	}
}
