using Openfort.SDK.Wrapper;

namespace Openfort.SDK
{
    public class OpenfortClient
    {
        private readonly string apiKey;
        private readonly string? basePath;

        public OpenfortClient(string apiKey, string? basePath = null)
        {
            this.apiKey = apiKey;
            this.basePath = basePath;
        }

        private AccountsApiWrapper? accounts;
        public AccountsApiWrapper Accounts
        {
            get
            {
                if (accounts == null)
                {
                    accounts = new AccountsApiWrapper(apiKey, basePath);
                }
                return accounts;
            }
        }
    }
}