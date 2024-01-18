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
    /// UpdatePolicyRequest
    /// </summary>
    [DataContract(Name = "UpdatePolicyRequest")]
    public partial class UpdatePolicyRequest : IEquatable<UpdatePolicyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePolicyRequest" /> class.
        /// </summary>
        /// <param name="name">Specifies the name of the policy..</param>
        /// <param name="chainId">The chain ID. Must be a [supported chain](/chains)..</param>
        /// <param name="strategy">strategy.</param>
        /// <param name="deleted">Specifies whether to delete the policy..</param>
        public UpdatePolicyRequest(string name = default(string), int chainId = default(int), PolicyStrategyRequest strategy = default(PolicyStrategyRequest), bool deleted = default(bool))
        {
            this.Name = name;
            this.ChainId = chainId;
            this.Strategy = strategy;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Specifies the name of the policy.
        /// </summary>
        /// <value>Specifies the name of the policy.</value>
        /// <example>&quot;My Policy&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The chain ID. Must be a [supported chain](/chains).
        /// </summary>
        /// <value>The chain ID. Must be a [supported chain](/chains).</value>
        /// <example>80001</example>
        [DataMember(Name = "chainId", EmitDefaultValue = false)]
        public int ChainId { get; set; }

        /// <summary>
        /// Gets or Sets Strategy
        /// </summary>
        [DataMember(Name = "strategy", EmitDefaultValue = false)]
        public PolicyStrategyRequest Strategy { get; set; }

        /// <summary>
        /// Specifies whether to delete the policy.
        /// </summary>
        /// <value>Specifies whether to delete the policy.</value>
        /// <example>false</example>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdatePolicyRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Strategy: ").Append(Strategy).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
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
            return this.Equals(input as UpdatePolicyRequest);
        }

        /// <summary>
        /// Returns true if UpdatePolicyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePolicyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePolicyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.Strategy == input.Strategy ||
                    (this.Strategy != null &&
                    this.Strategy.Equals(input.Strategy))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.Strategy != null)
                {
                    hashCode = (hashCode * 59) + this.Strategy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
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
