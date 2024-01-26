/*
 * Openfort API
 *
 * Complete Openfort API references and guides can be found at: https://openfort.xyz/docs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: founders@openfort.xyz
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Openfort.SDK.Client.FileParameter;
using OpenAPIDateConverter = Openfort.SDK.Client.OpenAPIDateConverter;

namespace Openfort.SDK.Model
{
    /// <summary>
    /// CreateTriggerRequest
    /// </summary>
    [DataContract(Name = "CreateTriggerRequest")]
    public partial class CreateTriggerRequest : IEquatable<CreateTriggerRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public NotificationTriggerType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTriggerRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTriggerRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTriggerRequest" /> class.
        /// </summary>
        /// <param name="notification">The notification ID (starts with not_). (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="functionName">The function name of the contract. Accepts a a function signature as well (e.g. mint(address))..</param>
        /// <param name="functionArgs">The function arguments of the contract, in string format. If you provide one of a &#x60;pla_...&#x60;, &#x60;con_...&#x60; or &#x60;acc_...&#x60; it will be converted to the corresponding address..</param>
        /// <param name="contract">The contract ID you want to interact with. Must have been added to Openfort first, starts with &#x60;con_&#x60;..</param>
        /// <param name="threshold">The threshold value at which (greater or equal) the notification will be triggered. (required).</param>
        /// <param name="chainId">The chain ID. Must be a [supported chain](/chains)..</param>
        /// <param name="account">ID of the Developer Account this trigger will check the balance of (starts with &#x60;dac_&#x60;)..</param>
        public CreateTriggerRequest(string notification = default(string), NotificationTriggerType type = default(NotificationTriggerType), string functionName = default(string), List<string> functionArgs = default(List<string>), string contract = default(string), string threshold = default(string), int chainId = default(int), string account = default(string))
        {
            // to ensure "notification" is required (not null)
            if (notification == null)
            {
                throw new ArgumentNullException("notification is a required property for CreateTriggerRequest and cannot be null");
            }
            this.Notification = notification;
            this.Type = type;
            // to ensure "threshold" is required (not null)
            if (threshold == null)
            {
                throw new ArgumentNullException("threshold is a required property for CreateTriggerRequest and cannot be null");
            }
            this.Threshold = threshold;
            this.FunctionName = functionName;
            this.FunctionArgs = functionArgs;
            this.Contract = contract;
            this.ChainId = chainId;
            this.Account = account;
        }

        /// <summary>
        /// The notification ID (starts with not_).
        /// </summary>
        /// <value>The notification ID (starts with not_).</value>
        /// <example>&quot;not_e0b84653-1741-4a3d-9e91-2b0fd2942f60&quot;</example>
        [DataMember(Name = "notification", IsRequired = true, EmitDefaultValue = true)]
        public string Notification { get; set; }

        /// <summary>
        /// The function name of the contract. Accepts a a function signature as well (e.g. mint(address)).
        /// </summary>
        /// <value>The function name of the contract. Accepts a a function signature as well (e.g. mint(address)).</value>
        /// <example>&quot;mint&quot;</example>
        [DataMember(Name = "functionName", EmitDefaultValue = false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// The function arguments of the contract, in string format. If you provide one of a &#x60;pla_...&#x60;, &#x60;con_...&#x60; or &#x60;acc_...&#x60; it will be converted to the corresponding address.
        /// </summary>
        /// <value>The function arguments of the contract, in string format. If you provide one of a &#x60;pla_...&#x60;, &#x60;con_...&#x60; or &#x60;acc_...&#x60; it will be converted to the corresponding address.</value>
        [DataMember(Name = "functionArgs", EmitDefaultValue = false)]
        public List<string> FunctionArgs { get; set; }

        /// <summary>
        /// The contract ID you want to interact with. Must have been added to Openfort first, starts with &#x60;con_&#x60;.
        /// </summary>
        /// <value>The contract ID you want to interact with. Must have been added to Openfort first, starts with &#x60;con_&#x60;.</value>
        /// <example>&quot;con_0cddb398-1dc6-4e6f-8726-9ec7cea85f35&quot;</example>
        [DataMember(Name = "contract", EmitDefaultValue = false)]
        public string Contract { get; set; }

        /// <summary>
        /// The threshold value at which (greater or equal) the notification will be triggered.
        /// </summary>
        /// <value>The threshold value at which (greater or equal) the notification will be triggered.</value>
        /// <example>&quot;1000000000&quot;</example>
        [DataMember(Name = "threshold", IsRequired = true, EmitDefaultValue = true)]
        public string Threshold { get; set; }

        /// <summary>
        /// The chain ID. Must be a [supported chain](/chains).
        /// </summary>
        /// <value>The chain ID. Must be a [supported chain](/chains).</value>
        /// <example>80001</example>
        [DataMember(Name = "chainId", EmitDefaultValue = false)]
        public int ChainId { get; set; }

        /// <summary>
        /// ID of the Developer Account this trigger will check the balance of (starts with &#x60;dac_&#x60;).
        /// </summary>
        /// <value>ID of the Developer Account this trigger will check the balance of (starts with &#x60;dac_&#x60;).</value>
        /// <example>&quot;dac_e1b24353-1741-4a3d-9e91-2b0fd2942f60&quot;</example>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public string Account { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTriggerRequest {\n");
            sb.Append("  Notification: ").Append(Notification).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FunctionName: ").Append(FunctionName).Append("\n");
            sb.Append("  FunctionArgs: ").Append(FunctionArgs).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTriggerRequest);
        }

        /// <summary>
        /// Returns true if CreateTriggerRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTriggerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTriggerRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Notification == input.Notification ||
                    (this.Notification != null &&
                    this.Notification.Equals(input.Notification))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.FunctionName == input.FunctionName ||
                    (this.FunctionName != null &&
                    this.FunctionName.Equals(input.FunctionName))
                ) && 
                (
                    this.FunctionArgs == input.FunctionArgs ||
                    this.FunctionArgs != null &&
                    input.FunctionArgs != null &&
                    this.FunctionArgs.SequenceEqual(input.FunctionArgs)
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Notification != null)
                {
                    hashCode = (hashCode * 59) + this.Notification.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.FunctionName != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionName.GetHashCode();
                }
                if (this.FunctionArgs != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionArgs.GetHashCode();
                }
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                if (this.Threshold != null)
                {
                    hashCode = (hashCode * 59) + this.Threshold.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
