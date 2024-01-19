namespace Openfort.SDK.Model
{
    public class DeveloperAccountRequest : BaseGetRequest<DeveloperAccountResponseExpandable>
    {
        public DeveloperAccountRequest(string id, List<DeveloperAccountResponseExpandable>? expand = null) : base(id, expand)
        {
        }
    }
}

