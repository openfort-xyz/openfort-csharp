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
    /// CreateWeb3ConnectionRequest
    /// </summary>
    [DataContract(Name = "CreateWeb3ConnectionRequest")]
    public partial class CreateWeb3ConnectionRequest : IEquatable<CreateWeb3ConnectionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWeb3ConnectionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWeb3ConnectionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWeb3ConnectionRequest" /> class.
        /// </summary>
        /// <param name="player">The player ID (starts with pla_). (required).</param>
        /// <param name="chainId">The chain ID. (required).</param>
        /// <param name="uri">Specifies the URI of WalletConnect. (required).</param>
        public CreateWeb3ConnectionRequest(string player = default(string), int chainId = default(int), string uri = default(string))
        {
            // to ensure "player" is required (not null)
            if (player == null)
            {
                throw new ArgumentNullException("player is a required property for CreateWeb3ConnectionRequest and cannot be null");
            }
            this.Player = player;
            this.ChainId = chainId;
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for CreateWeb3ConnectionRequest and cannot be null");
            }
            this.Uri = uri;
        }

        /// <summary>
        /// The player ID (starts with pla_).
        /// </summary>
        /// <value>The player ID (starts with pla_).</value>
        /// <example>&quot;pla_e0b84653-1741-4a3d-9e91-2b0fd2942f60&quot;</example>
        [DataMember(Name = "player", IsRequired = true, EmitDefaultValue = true)]
        public string Player { get; set; }

        /// <summary>
        /// The chain ID.
        /// </summary>
        /// <value>The chain ID.</value>
        /// <example>80001</example>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public int ChainId { get; set; }

        /// <summary>
        /// Specifies the URI of WalletConnect.
        /// </summary>
        /// <value>Specifies the URI of WalletConnect.</value>
        /// <example>&quot;wc:f6b98f7d78c5233413aacc7cbe9ff6035eec3611d36eb311051429a83af419a1@2?relay-protocol&#x3D;irn&amp;symKey&#x3D;e8b33b4b969dc952ba6d28bd58f0ddb7ec1106a3c9610961218061a7813f11a6&quot;</example>
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateWeb3ConnectionRequest {\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(input as CreateWeb3ConnectionRequest);
        }

        /// <summary>
        /// Returns true if CreateWeb3ConnectionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWeb3ConnectionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWeb3ConnectionRequest input)
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
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
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
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.Uri != null)
                {
                    hashCode = (hashCode * 59) + this.Uri.GetHashCode();
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
