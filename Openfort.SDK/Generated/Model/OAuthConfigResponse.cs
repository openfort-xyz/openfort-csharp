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
    /// OAuth provider specific configuration.
    /// </summary>
    [DataContract(Name = "OAuthConfigResponse")]
    public partial class OAuthConfigResponse : IEquatable<OAuthConfigResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthConfigResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OAuthConfigResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthConfigResponse" /> class.
        /// </summary>
        /// <param name="config">config (required).</param>
        public OAuthConfigResponse(AccelbyteOauthConfig config = default(AccelbyteOauthConfig))
        {
            // to ensure "config" is required (not null)
            if (config == null)
            {
                throw new ArgumentNullException("config is a required property for OAuthConfigResponse and cannot be null");
            }
            this.Config = config;
        }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", IsRequired = true, EmitDefaultValue = true)]
        public AccelbyteOauthConfig Config { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuthConfigResponse {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
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
            return this.Equals(input as OAuthConfigResponse);
        }

        /// <summary>
        /// Returns true if OAuthConfigResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuthConfigResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthConfigResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
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
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
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
