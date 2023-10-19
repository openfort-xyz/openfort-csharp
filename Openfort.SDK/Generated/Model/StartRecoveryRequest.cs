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
    /// StartRecoveryRequest
    /// </summary>
    [DataContract(Name = "StartRecoveryRequest")]
    public partial class StartRecoveryRequest : IEquatable<StartRecoveryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartRecoveryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StartRecoveryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StartRecoveryRequest" /> class.
        /// </summary>
        /// <param name="newOwnerAddress">Address of the new owner (required).</param>
        /// <param name="policy">The policy ID (starts with pol_) (required).</param>
        public StartRecoveryRequest(string newOwnerAddress = default(string), string policy = default(string))
        {
            // to ensure "newOwnerAddress" is required (not null)
            if (newOwnerAddress == null)
            {
                throw new ArgumentNullException("newOwnerAddress is a required property for StartRecoveryRequest and cannot be null");
            }
            this.NewOwnerAddress = newOwnerAddress;
            // to ensure "policy" is required (not null)
            if (policy == null)
            {
                throw new ArgumentNullException("policy is a required property for StartRecoveryRequest and cannot be null");
            }
            this.Policy = policy;
        }

        /// <summary>
        /// Address of the new owner
        /// </summary>
        /// <value>Address of the new owner</value>
        [DataMember(Name = "newOwnerAddress", IsRequired = true, EmitDefaultValue = true)]
        public string NewOwnerAddress { get; set; }

        /// <summary>
        /// The policy ID (starts with pol_)
        /// </summary>
        /// <value>The policy ID (starts with pol_)</value>
        [DataMember(Name = "policy", IsRequired = true, EmitDefaultValue = true)]
        public string Policy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StartRecoveryRequest {\n");
            sb.Append("  NewOwnerAddress: ").Append(NewOwnerAddress).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
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
            return this.Equals(input as StartRecoveryRequest);
        }

        /// <summary>
        /// Returns true if StartRecoveryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StartRecoveryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartRecoveryRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NewOwnerAddress == input.NewOwnerAddress ||
                    (this.NewOwnerAddress != null &&
                    this.NewOwnerAddress.Equals(input.NewOwnerAddress))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
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
                if (this.NewOwnerAddress != null)
                {
                    hashCode = (hashCode * 59) + this.NewOwnerAddress.GetHashCode();
                }
                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
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
