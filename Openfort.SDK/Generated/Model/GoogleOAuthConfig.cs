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
    /// Google oauth configuration
    /// </summary>
    [DataContract(Name = "GoogleOAuthConfig")]
    public partial class GoogleOAuthConfig : IEquatable<GoogleOAuthConfig>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = true)]
        public OAuthProviderGOOGLE Provider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleOAuthConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GoogleOAuthConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleOAuthConfig" /> class.
        /// </summary>
        /// <param name="enabled">Enable Google OAuth. (required).</param>
        /// <param name="clientId">Google API client ID. (required).</param>
        /// <param name="clientSecret">Google API client secret. (required).</param>
        /// <param name="redirectUri">The URI to redirect to after completing the auth request. You can use Openfort redirect URL: https://openfort.xyz/auth/v1/google/callback (required).</param>
        /// <param name="provider">provider (required).</param>
        public GoogleOAuthConfig(bool enabled = default(bool), string clientId = default(string), string clientSecret = default(string), string redirectUri = default(string), OAuthProviderGOOGLE provider = default(OAuthProviderGOOGLE))
        {
            this.Enabled = enabled;
            // to ensure "clientId" is required (not null)
            if (clientId == null)
            {
                throw new ArgumentNullException("clientId is a required property for GoogleOAuthConfig and cannot be null");
            }
            this.ClientId = clientId;
            // to ensure "clientSecret" is required (not null)
            if (clientSecret == null)
            {
                throw new ArgumentNullException("clientSecret is a required property for GoogleOAuthConfig and cannot be null");
            }
            this.ClientSecret = clientSecret;
            // to ensure "redirectUri" is required (not null)
            if (redirectUri == null)
            {
                throw new ArgumentNullException("redirectUri is a required property for GoogleOAuthConfig and cannot be null");
            }
            this.RedirectUri = redirectUri;
            this.Provider = provider;
        }

        /// <summary>
        /// Enable Google OAuth.
        /// </summary>
        /// <value>Enable Google OAuth.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Google API client ID.
        /// </summary>
        /// <value>Google API client ID.</value>
        [DataMember(Name = "clientId", IsRequired = true, EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Google API client secret.
        /// </summary>
        /// <value>Google API client secret.</value>
        [DataMember(Name = "clientSecret", IsRequired = true, EmitDefaultValue = true)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The URI to redirect to after completing the auth request. You can use Openfort redirect URL: https://openfort.xyz/auth/v1/google/callback
        /// </summary>
        /// <value>The URI to redirect to after completing the auth request. You can use Openfort redirect URL: https://openfort.xyz/auth/v1/google/callback</value>
        [DataMember(Name = "redirectUri", IsRequired = true, EmitDefaultValue = true)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoogleOAuthConfig {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
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
            return this.Equals(input as GoogleOAuthConfig);
        }

        /// <summary>
        /// Returns true if GoogleOAuthConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleOAuthConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleOAuthConfig input)
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
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.RedirectUri == input.RedirectUri ||
                    (this.RedirectUri != null &&
                    this.RedirectUri.Equals(input.RedirectUri))
                ) && 
                (
                    this.Provider == input.Provider ||
                    this.Provider.Equals(input.Provider)
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
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.ClientSecret != null)
                {
                    hashCode = (hashCode * 59) + this.ClientSecret.GetHashCode();
                }
                if (this.RedirectUri != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectUri.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Provider.GetHashCode();
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
