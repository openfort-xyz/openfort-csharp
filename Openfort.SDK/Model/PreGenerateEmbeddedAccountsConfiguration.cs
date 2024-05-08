using System.ComponentModel;

namespace Openfort.SDK.Model
{
    public enum ShieldAuthProvider
    {
        [Description("openfort")]
        Openfort,

        [Description("custom")]
        Custom,
    }

    public class PreGenerateEmbeddedAccountsConfiguration
    {
        public ShieldAuthProvider ShieldAuthProvider { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public string EncryptionPart { get; set; }
    }
}
