namespace Openfort.SDK.Model
{
	public class BaseGetRequest<T>
	{
        public BaseGetRequest(string id, List<T>? expand = null)
        {
            Id = id;
            Expand = expand ?? new List<T>();
        }

        public string Id { get; set; }

        public List<T> Expand { get; set; }
    }
}

