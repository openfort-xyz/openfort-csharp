using Microsoft.Extensions.Configuration;

namespace Openfort.SDK.Tests
{
	public static class ApiKeys
	{
        private static IConfiguration Config { get; set; }

        static ApiKeys()
		{
            //var StartupPath = Path.GetDirectoryName();
            Console.Write(Directory.GetCurrentDirectory());
            Config = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true).Build();
        }

        public static string SecretKey
        {
            get
            {
                var result = Config["secretKey"];
                if (result == null)
                {
                    throw new Exception("Config was not found");
                }
                return result;
            }
        }
    }
}
