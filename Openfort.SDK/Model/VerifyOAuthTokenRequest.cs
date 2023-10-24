namespace Openfort.SDK.Model
{
	public class VerifyOAuthTokenRequest: OAuthRequest
    {
		public VerifyOAuthTokenRequest(OAuthProvider provider, string token): base(token)
		{
            Provider = provider;
		}

        public OAuthProvider Provider { get; set; }
    }
}

