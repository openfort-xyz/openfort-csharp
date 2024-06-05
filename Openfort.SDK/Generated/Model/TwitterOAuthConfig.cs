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
    /// Twitter oauth configuration
    /// </summary>
    [DataContract(Name = "TwitterOAuthConfig")]
    public partial class TwitterOAuthConfig : IEquatable<TwitterOAuthConfig>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = true)]
        public OAuthProviderTWITTER Provider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterOAuthConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TwitterOAuthConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterOAuthConfig" /> class.
        /// </summary>
        /// <param name="enabled">Enable OAuth provider. (required).</param>
        /// <param name="provider">provider (required).</param>
        /// <param name="clientId">Twitter API consumer key. (required).</param>
        /// <param name="clientSecret">Twitter API consumer secret. (required).</param>
        public TwitterOAuthConfig(bool enabled = default(bool), OAuthProviderTWITTER provider = default(OAuthProviderTWITTER), string clientId = default(string), string clientSecret = default(string))
        {
            this.Enabled = enabled;
            this.Provider = provider;
            // to ensure "clientId" is required (not null)
            if (clientId == null)
            {
                throw new ArgumentNullException("clientId is a required property for TwitterOAuthConfig and cannot be null");
            }
            this.ClientId = clientId;
            // to ensure "clientSecret" is required (not null)
            if (clientSecret == null)
            {
                throw new ArgumentNullException("clientSecret is a required property for TwitterOAuthConfig and cannot be null");
            }
            this.ClientSecret = clientSecret;
        }

        /// <summary>
        /// Enable OAuth provider.
        /// </summary>
        /// <value>Enable OAuth provider.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Twitter API consumer key.
        /// </summary>
        /// <value>Twitter API consumer key.</value>
        [DataMember(Name = "clientId", IsRequired = true, EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Twitter API consumer secret.
        /// </summary>
        /// <value>Twitter API consumer secret.</value>
        [DataMember(Name = "clientSecret", IsRequired = true, EmitDefaultValue = true)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TwitterOAuthConfig {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
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
            return this.Equals(input as TwitterOAuthConfig);
        }

        /// <summary>
        /// Returns true if TwitterOAuthConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of TwitterOAuthConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwitterOAuthConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Provider == input.Provider ||
                    this.Provider.Equals(input.Provider)
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
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
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.ClientSecret != null)
                {
                    hashCode = (hashCode * 59) + this.ClientSecret.GetHashCode();
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
