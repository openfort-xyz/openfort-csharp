namespace Openfort.SDK.Model
{
	public class BaseListRequest
	{
		public BaseListRequest(int? limit = null, int? skip = null, SortOrder? order = null) {
			Limit = limit;
			Skip = skip;
			Order = order;
		}

        public int? Limit { get; set; }

		public int? Skip { get; set; }

		public SortOrder? Order { get; set; }
    }
}

