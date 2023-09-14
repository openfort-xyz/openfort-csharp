using Openfort.SDK.Client;

namespace Openfort.SDK.Wrapper
{
	public class BaseApiWrapper
	{
		public BaseApiWrapper(string accessToken, string? basePath = null)
		{
            Configuration = new Configuration()
            {
                AccessToken = accessToken,
            };
            if (basePath != null)
            {
                Configuration.BasePath = basePath;
            }
        }

        public Configuration Configuration { get; private set; }
    }
}

