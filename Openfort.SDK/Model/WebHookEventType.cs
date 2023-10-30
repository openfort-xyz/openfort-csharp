using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Openfort.SDK.Model
{
    /// <summary>
    /// Defines the type of the evnt that was received by webhook
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebHookEventType
    {
        /// <summary>
        /// Transaction intent has been successfully finished
        /// </summary>
        [EnumMember(Value = "transaction_intent.succeeded")]
        TransactionIntentSucceeded = 1,
        /// <summary>
        /// Transation intent failed
        /// </summary>
        [EnumMember(Value = "transaction_intent.failed")]
        TransactionIntentFailed = 2,

    }
}

