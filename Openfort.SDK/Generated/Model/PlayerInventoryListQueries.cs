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
    /// PlayerInventoryListQueries
    /// </summary>
    [DataContract(Name = "PlayerInventoryListQueries")]
    public partial class PlayerInventoryListQueries : IEquatable<PlayerInventoryListQueries>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public SortOrder? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerInventoryListQueries" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlayerInventoryListQueries() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerInventoryListQueries" /> class.
        /// </summary>
        /// <param name="limit">Specifies the maximum number of records to return..</param>
        /// <param name="skip">Specifies the offset for the first records to return..</param>
        /// <param name="order">order.</param>
        /// <param name="contractId">Filter by contract ID (starts with con_)..</param>
        /// <param name="chainId">Filter by chain id. (required).</param>
        public PlayerInventoryListQueries(int limit = default(int), int skip = default(int), SortOrder? order = default(SortOrder?), List<string> contractId = default(List<string>), int chainId = default(int))
        {
            this.ChainId = chainId;
            this.Limit = limit;
            this.Skip = skip;
            this.Order = order;
            this.ContractId = contractId;
        }

        /// <summary>
        /// Specifies the maximum number of records to return.
        /// </summary>
        /// <value>Specifies the maximum number of records to return.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// Specifies the offset for the first records to return.
        /// </summary>
        /// <value>Specifies the offset for the first records to return.</value>
        [DataMember(Name = "skip", EmitDefaultValue = false)]
        public int Skip { get; set; }

        /// <summary>
        /// Filter by contract ID (starts with con_).
        /// </summary>
        /// <value>Filter by contract ID (starts with con_).</value>
        [DataMember(Name = "contractId", EmitDefaultValue = false)]
        public List<string> ContractId { get; set; }

        /// <summary>
        /// Filter by chain id.
        /// </summary>
        /// <value>Filter by chain id.</value>
        /// <example>80001</example>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public int ChainId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerInventoryListQueries {\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
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
            return this.Equals(input as PlayerInventoryListQueries);
        }

        /// <summary>
        /// Returns true if PlayerInventoryListQueries instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerInventoryListQueries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerInventoryListQueries input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.Skip == input.Skip ||
                    this.Skip.Equals(input.Skip)
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.ContractId == input.ContractId ||
                    this.ContractId != null &&
                    input.ContractId != null &&
                    this.ContractId.SequenceEqual(input.ContractId)
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
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
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                hashCode = (hashCode * 59) + this.Skip.GetHashCode();
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
                if (this.ContractId != null)
                {
                    hashCode = (hashCode * 59) + this.ContractId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
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
            // Limit (int) minimum
            if (this.Limit < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value greater than or equal to 1.", new [] { "Limit" });
            }

            // Skip (int) minimum
            if (this.Skip < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Skip, must be a value greater than or equal to 0.", new [] { "Skip" });
            }

            yield break;
        }
    }

}
