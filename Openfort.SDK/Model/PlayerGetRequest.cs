namespace Openfort.SDK.Model
{
	public class PlayerGetRequest : BaseGetRequest<PlayerResponseExpandable>
    {
		public PlayerGetRequest(string id, List<PlayerResponseExpandable>? expand = null): base(id, expand)
		{
        }
    }
}

