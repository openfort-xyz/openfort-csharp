namespace Openfort.SDK.Model
{
    public class NotificationRequest : BaseGetRequest<NotificationResponseExpandable>
    {
        public NotificationRequest(string id, List<NotificationResponseExpandable>? expand = null) : base(id, expand)
        {
        }
    }
}

