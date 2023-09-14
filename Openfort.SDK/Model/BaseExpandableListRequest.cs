namespace Openfort.SDK.Model
{
	public class BaseExpandableListRequest<T>: BaseListRequest
    {
		public BaseExpandableListRequest(int? limit = null, int? skip = null, SortOrder? order = null, List<T>? expand = null): base(limit, skip, order) {
			Expand = expand ?? new List<T>(); ;
		}

		public List<T> Expand { get; set; }
    }
}

