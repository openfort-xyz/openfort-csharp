namespace Openfort.SDK.Model
{
    public class PlayerRequest : BaseGetRequest<PlayerResponseExpandable>
    {
        public PlayerRequest(string id, List<PlayerResponseExpandable>? expand = null) : base(id, expand)
        {
        }
    }
}

