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
    /// AccountListQueries
    /// </summary>
    [DataContract(Name = "AccountListQueries")]
    public partial class AccountListQueries : IEquatable<AccountListQueries>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public SortOrder? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountListQueries" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountListQueries() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountListQueries" /> class.
        /// </summary>
        /// <param name="limit">Specifies the maximum number of records to return..</param>
        /// <param name="skip">Specifies the offset for the first records to return..</param>
        /// <param name="order">order.</param>
        /// <param name="expand">Specifies the fields to expand in the response..</param>
        /// <param name="player">Specifies the unique player ID (starts with pla_) (required).</param>
        public AccountListQueries(double limit = default(double), double skip = default(double), SortOrder? order = default(SortOrder?), List<AccountResponseExpandable> expand = default(List<AccountResponseExpandable>), string player = default(string))
        {
            // to ensure "player" is required (not null)
            if (player == null)
            {
                throw new ArgumentNullException("player is a required property for AccountListQueries and cannot be null");
            }
            this.Player = player;
            this.Limit = limit;
            this.Skip = skip;
            this.Order = order;
            this.Expand = expand;
        }

        /// <summary>
        /// Specifies the maximum number of records to return.
        /// </summary>
        /// <value>Specifies the maximum number of records to return.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public double Limit { get; set; }

        /// <summary>
        /// Specifies the offset for the first records to return.
        /// </summary>
        /// <value>Specifies the offset for the first records to return.</value>
        [DataMember(Name = "skip", EmitDefaultValue = false)]
        public double Skip { get; set; }

        /// <summary>
        /// Specifies the fields to expand in the response.
        /// </summary>
        /// <value>Specifies the fields to expand in the response.</value>
        [DataMember(Name = "expand", EmitDefaultValue = false)]
        public List<AccountResponseExpandable> Expand { get; set; }

        /// <summary>
        /// Specifies the unique player ID (starts with pla_)
        /// </summary>
        /// <value>Specifies the unique player ID (starts with pla_)</value>
        [DataMember(Name = "player", IsRequired = true, EmitDefaultValue = true)]
        public string Player { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountListQueries {\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Expand: ").Append(Expand).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
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
            return this.Equals(input as AccountListQueries);
        }

        /// <summary>
        /// Returns true if AccountListQueries instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountListQueries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountListQueries input)
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
                    this.Expand == input.Expand ||
                    this.Expand != null &&
                    input.Expand != null &&
                    this.Expand.SequenceEqual(input.Expand)
                ) && 
                (
                    this.Player == input.Player ||
                    (this.Player != null &&
                    this.Player.Equals(input.Player))
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
                if (this.Expand != null)
                {
                    hashCode = (hashCode * 59) + this.Expand.GetHashCode();
                }
                if (this.Player != null)
                {
                    hashCode = (hashCode * 59) + this.Player.GetHashCode();
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
