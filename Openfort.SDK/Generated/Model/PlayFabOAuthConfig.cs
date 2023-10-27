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
    /// PlayFab oauth configuration
    /// </summary>
    [DataContract(Name = "PlayFabOAuthConfig")]
    public partial class PlayFabOAuthConfig : IEquatable<PlayFabOAuthConfig>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = true)]
        public OAuthProviderPLAYFAB Provider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayFabOAuthConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlayFabOAuthConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayFabOAuthConfig" /> class.
        /// </summary>
        /// <param name="enabled">Enable PlayFab Auth. (required).</param>
        /// <param name="titleId">Title ID of your Play Fab gaming service environment. (required).</param>
        /// <param name="provider">provider (required).</param>
        public PlayFabOAuthConfig(bool enabled = default(bool), string titleId = default(string), OAuthProviderPLAYFAB provider = default(OAuthProviderPLAYFAB))
        {
            this.Enabled = enabled;
            // to ensure "titleId" is required (not null)
            if (titleId == null)
            {
                throw new ArgumentNullException("titleId is a required property for PlayFabOAuthConfig and cannot be null");
            }
            this.TitleId = titleId;
            this.Provider = provider;
        }

        /// <summary>
        /// Enable PlayFab Auth.
        /// </summary>
        /// <value>Enable PlayFab Auth.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Title ID of your Play Fab gaming service environment.
        /// </summary>
        /// <value>Title ID of your Play Fab gaming service environment.</value>
        [DataMember(Name = "titleId", IsRequired = true, EmitDefaultValue = true)]
        public string TitleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayFabOAuthConfig {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  TitleId: ").Append(TitleId).Append("\n");
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
            return this.Equals(input as PlayFabOAuthConfig);
        }

        /// <summary>
        /// Returns true if PlayFabOAuthConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayFabOAuthConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayFabOAuthConfig input)
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
                    this.TitleId == input.TitleId ||
                    (this.TitleId != null &&
                    this.TitleId.Equals(input.TitleId))
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
                if (this.TitleId != null)
                {
                    hashCode = (hashCode * 59) + this.TitleId.GetHashCode();
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
