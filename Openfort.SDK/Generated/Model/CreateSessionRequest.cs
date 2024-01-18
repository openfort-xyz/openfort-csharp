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
    /// CreateSessionRequest
    /// </summary>
    [DataContract(Name = "CreateSessionRequest")]
    public partial class CreateSessionRequest : IEquatable<CreateSessionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSessionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionRequest" /> class.
        /// </summary>
        /// <param name="address">The address of the session key. (required).</param>
        /// <param name="chainId">The chain ID. Must be a [supported chain](/chains). (required).</param>
        /// <param name="externalOwnerAddress">If no account exists for a given player, create one with this address..</param>
        /// <param name="limit">Maximum number of times the session key can be used..</param>
        /// <param name="optimistic">Set to &#x60;true&#x60; to indicate that the transactionIntent request should be resolved as soon as possible, after the transactionIntent is created and simulated and before it arrives on chain..</param>
        /// <param name="policy">ID of the Policy that defines the gas sponsorship strategy (starts with &#x60;pol_&#x60;). If no Policy is provided, the own Account native token funds will be used to pay for gas..</param>
        /// <param name="validAfter">The unix timestamp in seconds when the session key becomes valid. (required).</param>
        /// <param name="validUntil">The unix timestamp in seconds when the session key expires. (required).</param>
        /// <param name="whitelist">The list of whitelisted addresses (contracts the session key can interact with)..</param>
        /// <param name="player">The player ID (starts with pla_). (required).</param>
        public CreateSessionRequest(string address = default(string), int chainId = default(int), string externalOwnerAddress = default(string), int limit = default(int), bool optimistic = default(bool), string policy = default(string), int validAfter = default(int), int validUntil = default(int), List<string> whitelist = default(List<string>), string player = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for CreateSessionRequest and cannot be null");
            }
            this.Address = address;
            this.ChainId = chainId;
            this.ValidAfter = validAfter;
            this.ValidUntil = validUntil;
            // to ensure "player" is required (not null)
            if (player == null)
            {
                throw new ArgumentNullException("player is a required property for CreateSessionRequest and cannot be null");
            }
            this.Player = player;
            this.ExternalOwnerAddress = externalOwnerAddress;
            this.Limit = limit;
            this.Optimistic = optimistic;
            this.Policy = policy;
            this.Whitelist = whitelist;
        }

        /// <summary>
        /// The address of the session key.
        /// </summary>
        /// <value>The address of the session key.</value>
        /// <example>&quot;0x1234567890abcdef1234567890abcdef12345678&quot;</example>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The chain ID. Must be a [supported chain](/chains).
        /// </summary>
        /// <value>The chain ID. Must be a [supported chain](/chains).</value>
        /// <example>80001</example>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public int ChainId { get; set; }

        /// <summary>
        /// If no account exists for a given player, create one with this address.
        /// </summary>
        /// <value>If no account exists for a given player, create one with this address.</value>
        /// <example>&quot;0x1234567890abcdef1234567890abcdef12345678&quot;</example>
        [DataMember(Name = "externalOwnerAddress", EmitDefaultValue = false)]
        public string ExternalOwnerAddress { get; set; }

        /// <summary>
        /// Maximum number of times the session key can be used.
        /// </summary>
        /// <value>Maximum number of times the session key can be used.</value>
        /// <example>1000</example>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// Set to &#x60;true&#x60; to indicate that the transactionIntent request should be resolved as soon as possible, after the transactionIntent is created and simulated and before it arrives on chain.
        /// </summary>
        /// <value>Set to &#x60;true&#x60; to indicate that the transactionIntent request should be resolved as soon as possible, after the transactionIntent is created and simulated and before it arrives on chain.</value>
        /// <example>true</example>
        [DataMember(Name = "optimistic", EmitDefaultValue = true)]
        public bool Optimistic { get; set; }

        /// <summary>
        /// ID of the Policy that defines the gas sponsorship strategy (starts with &#x60;pol_&#x60;). If no Policy is provided, the own Account native token funds will be used to pay for gas.
        /// </summary>
        /// <value>ID of the Policy that defines the gas sponsorship strategy (starts with &#x60;pol_&#x60;). If no Policy is provided, the own Account native token funds will be used to pay for gas.</value>
        /// <example>&quot;pol_7e07ae30-2a4d-48fa-803f-361da94905dd&quot;</example>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public string Policy { get; set; }

        /// <summary>
        /// The unix timestamp in seconds when the session key becomes valid.
        /// </summary>
        /// <value>The unix timestamp in seconds when the session key becomes valid.</value>
        /// <example>10</example>
        [DataMember(Name = "validAfter", IsRequired = true, EmitDefaultValue = true)]
        public int ValidAfter { get; set; }

        /// <summary>
        /// The unix timestamp in seconds when the session key expires.
        /// </summary>
        /// <value>The unix timestamp in seconds when the session key expires.</value>
        /// <example>123512123</example>
        [DataMember(Name = "validUntil", IsRequired = true, EmitDefaultValue = true)]
        public int ValidUntil { get; set; }

        /// <summary>
        /// The list of whitelisted addresses (contracts the session key can interact with).
        /// </summary>
        /// <value>The list of whitelisted addresses (contracts the session key can interact with).</value>
        [DataMember(Name = "whitelist", EmitDefaultValue = false)]
        public List<string> Whitelist { get; set; }

        /// <summary>
        /// The player ID (starts with pla_).
        /// </summary>
        /// <value>The player ID (starts with pla_).</value>
        /// <example>&quot;pla_e0b84653-1741-4a3d-9e91-2b0fd2942f60&quot;</example>
        [DataMember(Name = "player", IsRequired = true, EmitDefaultValue = true)]
        public string Player { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSessionRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  ExternalOwnerAddress: ").Append(ExternalOwnerAddress).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  ValidAfter: ").Append(ValidAfter).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
            sb.Append("  Whitelist: ").Append(Whitelist).Append("\n");
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
            return this.Equals(input as CreateSessionRequest);
        }

        /// <summary>
        /// Returns true if CreateSessionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSessionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSessionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.ExternalOwnerAddress == input.ExternalOwnerAddress ||
                    (this.ExternalOwnerAddress != null &&
                    this.ExternalOwnerAddress.Equals(input.ExternalOwnerAddress))
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.Optimistic == input.Optimistic ||
                    this.Optimistic.Equals(input.Optimistic)
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.ValidAfter == input.ValidAfter ||
                    this.ValidAfter.Equals(input.ValidAfter)
                ) && 
                (
                    this.ValidUntil == input.ValidUntil ||
                    this.ValidUntil.Equals(input.ValidUntil)
                ) && 
                (
                    this.Whitelist == input.Whitelist ||
                    this.Whitelist != null &&
                    input.Whitelist != null &&
                    this.Whitelist.SequenceEqual(input.Whitelist)
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.ExternalOwnerAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalOwnerAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                hashCode = (hashCode * 59) + this.Optimistic.GetHashCode();
                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValidAfter.GetHashCode();
                hashCode = (hashCode * 59) + this.ValidUntil.GetHashCode();
                if (this.Whitelist != null)
                {
                    hashCode = (hashCode * 59) + this.Whitelist.GetHashCode();
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
            // Limit (int) minimum
            if (this.Limit < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value greater than or equal to 1.", new [] { "Limit" });
            }

            yield break;
        }
    }

}
