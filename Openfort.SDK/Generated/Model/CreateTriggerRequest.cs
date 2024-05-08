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
        public APITriggerType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTriggerRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTriggerRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTriggerRequest" /> class.
        /// </summary>
        /// <param name="target">Specifies the target of the trigger (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="subscription">Specifies the subscription ID.</param>
        public CreateTriggerRequest(string target = default(string), APITriggerType type = default(APITriggerType), string subscription = default(string))
        {
            // to ensure "target" is required (not null)
            if (target == null)
            {
                throw new ArgumentNullException("target is a required property for CreateTriggerRequest and cannot be null");
            }
            this.Target = target;
            this.Type = type;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Specifies the target of the trigger
        /// </summary>
        /// <value>Specifies the target of the trigger</value>
        /// <example>&quot;https://example.com&quot;</example>
        [DataMember(Name = "target", IsRequired = true, EmitDefaultValue = true)]
        public string Target { get; set; }

        /// <summary>
        /// Specifies the subscription ID
        /// </summary>
        /// <value>Specifies the subscription ID</value>
        /// <example>&quot;sub_6f6c9067-89fa-4fc8-ac72-c242a268c584&quot;</example>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public string Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTriggerRequest {\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
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
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
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
                if (this.Target != null)
                {
                    hashCode = (hashCode * 59) + this.Target.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Subscription != null)
                {
                    hashCode = (hashCode * 59) + this.Subscription.GetHashCode();
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
