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
    /// PlayerResponse
    /// </summary>
    [DataContract(Name = "PlayerResponse")]
    public partial class PlayerResponse : IEquatable<PlayerResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public EntityTypePLAYER Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlayerResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerResponse" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="_object">_object (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="transactionIntents">transactionIntents.</param>
        /// <param name="accounts">accounts.</param>
        public PlayerResponse(string id = default(string), EntityTypePLAYER _object = default(EntityTypePLAYER), int createdAt = default(int), string name = default(string), string description = default(string), Dictionary<string, object> metadata = default(Dictionary<string, object>), List<PlayerResponseTransactionIntentsInner> transactionIntents = default(List<PlayerResponseTransactionIntentsInner>), List<PlayerResponseAccountsInner> accounts = default(List<PlayerResponseAccountsInner>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for PlayerResponse and cannot be null");
            }
            this.Id = id;
            this.Object = _object;
            this.CreatedAt = createdAt;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PlayerResponse and cannot be null");
            }
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
            this.TransactionIntents = transactionIntents;
            this.Accounts = accounts;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public int CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets TransactionIntents
        /// </summary>
        [DataMember(Name = "transactionIntents", EmitDefaultValue = false)]
        public List<PlayerResponseTransactionIntentsInner> TransactionIntents { get; set; }

        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name = "accounts", EmitDefaultValue = false)]
        public List<PlayerResponseAccountsInner> Accounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  TransactionIntents: ").Append(TransactionIntents).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
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
            return this.Equals(input as PlayerResponse);
        }

        /// <summary>
        /// Returns true if PlayerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.Object == input.Object ||
                    this.Object.Equals(input.Object)
                ) &&
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) &&
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) &&
                (
                    this.TransactionIntents == input.TransactionIntents ||
                    this.TransactionIntents != null &&
                    input.TransactionIntents != null &&
                    this.TransactionIntents.SequenceEqual(input.TransactionIntents)
                ) &&
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Object.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.TransactionIntents != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionIntents.GetHashCode();
                }
                if (this.Accounts != null)
                {
                    hashCode = (hashCode * 59) + this.Accounts.GetHashCode();
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
