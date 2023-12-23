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
    /// PlayerInventoryQueries
    /// </summary>
    [DataContract(Name = "PlayerInventoryQueries")]
    public partial class PlayerInventoryQueries : IEquatable<PlayerInventoryQueries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerInventoryQueries" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlayerInventoryQueries() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerInventoryQueries" /> class.
        /// </summary>
        /// <param name="chainId">Filter by chain id. (required).</param>
        public PlayerInventoryQueries(int chainId = default(int))
        {
            this.ChainId = chainId;
        }

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
            sb.Append("class PlayerInventoryQueries {\n");
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
            return this.Equals(input as PlayerInventoryQueries);
        }

        /// <summary>
        /// Returns true if PlayerInventoryQueries instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerInventoryQueries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerInventoryQueries input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
            yield break;
        }
    }

}
