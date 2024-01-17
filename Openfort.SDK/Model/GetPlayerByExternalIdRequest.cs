namespace Openfort.SDK.Model
{
	public class GetPlayerByExternalIdRequest
	{
		public GetPlayerByExternalIdRequest(OAuthProvider provider, string externalUserId)
		{
			Provider = provider;
			ExternalUserId = externalUserId;
		}

		public OAuthProvider Provider { get; set; }

		public string ExternalUserId { get; set; }
	}
}

