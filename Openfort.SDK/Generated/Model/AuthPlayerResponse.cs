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
    /// AuthPlayerResponse
    /// </summary>
    [DataContract(Name = "AuthPlayerResponse")]
    public partial class AuthPlayerResponse : IEquatable<AuthPlayerResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public EntityTypePLAYER Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthPlayerResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthPlayerResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthPlayerResponse" /> class.
        /// </summary>
        /// <param name="player">player.</param>
        /// <param name="id">id (required).</param>
        /// <param name="_object">_object (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="email">email.</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="lastSignInAt">lastSignInAt.</param>
        /// <param name="rawAppMetaData">rawAppMetaData.</param>
        public AuthPlayerResponse(AuthPlayerResponsePlayer player = default(AuthPlayerResponsePlayer), string id = default(string), EntityTypePLAYER _object = default(EntityTypePLAYER), int createdAt = default(int), string email = default(string), double updatedAt = default(double), double lastSignInAt = default(double), PrismaInputJsonValue rawAppMetaData = default(PrismaInputJsonValue))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AuthPlayerResponse and cannot be null");
            }
            this.Id = id;
            this.Object = _object;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Player = player;
            this.Email = email;
            this.LastSignInAt = lastSignInAt;
            this.RawAppMetaData = rawAppMetaData;
        }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        public AuthPlayerResponsePlayer Player { get; set; }

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
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public double UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets LastSignInAt
        /// </summary>
        [DataMember(Name = "lastSignInAt", EmitDefaultValue = false)]
        public double LastSignInAt { get; set; }

        /// <summary>
        /// Gets or Sets RawAppMetaData
        /// </summary>
        [DataMember(Name = "rawAppMetaData", EmitDefaultValue = false)]
        public PrismaInputJsonValue RawAppMetaData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthPlayerResponse {\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  LastSignInAt: ").Append(LastSignInAt).Append("\n");
            sb.Append("  RawAppMetaData: ").Append(RawAppMetaData).Append("\n");
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
            return this.Equals(input as AuthPlayerResponse);
        }

        /// <summary>
        /// Returns true if AuthPlayerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthPlayerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthPlayerResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Player == input.Player ||
                    (this.Player != null &&
                    this.Player.Equals(input.Player))
                ) && 
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    this.UpdatedAt.Equals(input.UpdatedAt)
                ) && 
                (
                    this.LastSignInAt == input.LastSignInAt ||
                    this.LastSignInAt.Equals(input.LastSignInAt)
                ) && 
                (
                    this.RawAppMetaData == input.RawAppMetaData ||
                    (this.RawAppMetaData != null &&
                    this.RawAppMetaData.Equals(input.RawAppMetaData))
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
                if (this.Player != null)
                {
                    hashCode = (hashCode * 59) + this.Player.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Object.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.LastSignInAt.GetHashCode();
                if (this.RawAppMetaData != null)
                {
                    hashCode = (hashCode * 59) + this.RawAppMetaData.GetHashCode();
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
