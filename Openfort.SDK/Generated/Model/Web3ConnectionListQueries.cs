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
    /// Web3ConnectionListQueries
    /// </summary>
    [DataContract(Name = "Web3ConnectionListQueries")]
    public partial class Web3ConnectionListQueries : IEquatable<Web3ConnectionListQueries>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public SortOrder? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Web3ConnectionListQueries" /> class.
        /// </summary>
        /// <param name="limit">Specifies the maximum number of records to return..</param>
        /// <param name="skip">Specifies the offset for the first records to return..</param>
        /// <param name="order">order.</param>
        /// <param name="player">Specifies the unique player ID (starts with pla_).</param>
        /// <param name="disconnected">Specifies connection status.</param>
        public Web3ConnectionListQueries(int limit = default(int), int skip = default(int), SortOrder? order = default(SortOrder?), string player = default(string), bool disconnected = default(bool))
        {
            this.Limit = limit;
            this.Skip = skip;
            this.Order = order;
            this.Player = player;
            this.Disconnected = disconnected;
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
        /// Specifies the unique player ID (starts with pla_)
        /// </summary>
        /// <value>Specifies the unique player ID (starts with pla_)</value>
        /// <example>&quot;pla_6f6c9067-89fa-4fc8-ac72-c242a268c584&quot;</example>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        public string Player { get; set; }

        /// <summary>
        /// Specifies connection status
        /// </summary>
        /// <value>Specifies connection status</value>
        /// <example>false</example>
        [DataMember(Name = "disconnected", EmitDefaultValue = true)]
        public bool Disconnected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Web3ConnectionListQueries {\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Disconnected: ").Append(Disconnected).Append("\n");
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
            return this.Equals(input as Web3ConnectionListQueries);
        }

        /// <summary>
        /// Returns true if Web3ConnectionListQueries instances are equal
        /// </summary>
        /// <param name="input">Instance of Web3ConnectionListQueries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Web3ConnectionListQueries input)
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
                    this.Player == input.Player ||
                    (this.Player != null &&
                    this.Player.Equals(input.Player))
                ) && 
                (
                    this.Disconnected == input.Disconnected ||
                    this.Disconnected.Equals(input.Disconnected)
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
                if (this.Player != null)
                {
                    hashCode = (hashCode * 59) + this.Player.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Disconnected.GetHashCode();
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
