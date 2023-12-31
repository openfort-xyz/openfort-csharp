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
    /// PaymasterDepositorCreateRequest
    /// </summary>
    [DataContract(Name = "PaymasterDepositorCreateRequest")]
    public partial class PaymasterDepositorCreateRequest : IEquatable<PaymasterDepositorCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymasterDepositorCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymasterDepositorCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymasterDepositorCreateRequest" /> class.
        /// </summary>
        /// <param name="depositorAddress">The address of the wallet that has deposited in the paymaster. (required).</param>
        /// <param name="signature">Signature to verify the account ownership. (required).</param>
        public PaymasterDepositorCreateRequest(string depositorAddress = default(string), string signature = default(string))
        {
            // to ensure "depositorAddress" is required (not null)
            if (depositorAddress == null)
            {
                throw new ArgumentNullException("depositorAddress is a required property for PaymasterDepositorCreateRequest and cannot be null");
            }
            this.DepositorAddress = depositorAddress;
            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new ArgumentNullException("signature is a required property for PaymasterDepositorCreateRequest and cannot be null");
            }
            this.Signature = signature;
        }

        /// <summary>
        /// The address of the wallet that has deposited in the paymaster.
        /// </summary>
        /// <value>The address of the wallet that has deposited in the paymaster.</value>
        /// <example>&quot;0x662D24Bf7Ea2dD6a7D0935F680a6056b94fE934d&quot;</example>
        [DataMember(Name = "depositorAddress", IsRequired = true, EmitDefaultValue = true)]
        public string DepositorAddress { get; set; }

        /// <summary>
        /// Signature to verify the account ownership.
        /// </summary>
        /// <value>Signature to verify the account ownership.</value>
        /// <example>&quot;0x1234567890abcdef1234567890abcdef1234567890abcdef1234567890abcdef&quot;</example>
        [DataMember(Name = "signature", IsRequired = true, EmitDefaultValue = true)]
        public string Signature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymasterDepositorCreateRequest {\n");
            sb.Append("  DepositorAddress: ").Append(DepositorAddress).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(input as PaymasterDepositorCreateRequest);
        }

        /// <summary>
        /// Returns true if PaymasterDepositorCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymasterDepositorCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymasterDepositorCreateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DepositorAddress == input.DepositorAddress ||
                    (this.DepositorAddress != null &&
                    this.DepositorAddress.Equals(input.DepositorAddress))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
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
                if (this.DepositorAddress != null)
                {
                    hashCode = (hashCode * 59) + this.DepositorAddress.GetHashCode();
                }
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
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
