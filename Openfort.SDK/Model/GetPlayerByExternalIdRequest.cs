namespace Openfort.SDK.Model
{
	public class GetPlayerByExternalIdRequest
	{
		public GetPlayerByExternalIdRequest(OAuthProvider provider, string externalId)
		{
			Provider = provider;
			ExternalId = externalId;
		}

        public OAuthProvider Provider { get; set; }

        public string ExternalId { get; set; }
    }
}

