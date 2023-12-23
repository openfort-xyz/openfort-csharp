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
    /// Stat
    /// </summary>
    [DataContract(Name = "Stat")]
    public partial class Stat : IEquatable<Stat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Stat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Stat" /> class.
        /// </summary>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="total">total (required).</param>
        /// <param name="successful">successful (required).</param>
        /// <param name="gasUsed">gasUsed (required).</param>
        public Stat(string timestamp = default(string), int total = default(int), int successful = default(int), string gasUsed = default(string))
        {
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new ArgumentNullException("timestamp is a required property for Stat and cannot be null");
            }
            this.Timestamp = timestamp;
            this.Total = total;
            this.Successful = successful;
            // to ensure "gasUsed" is required (not null)
            if (gasUsed == null)
            {
                throw new ArgumentNullException("gasUsed is a required property for Stat and cannot be null");
            }
            this.GasUsed = gasUsed;
        }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public int Total { get; set; }

        /// <summary>
        /// Gets or Sets Successful
        /// </summary>
        [DataMember(Name = "successful", IsRequired = true, EmitDefaultValue = true)]
        public int Successful { get; set; }

        /// <summary>
        /// Gets or Sets GasUsed
        /// </summary>
        [DataMember(Name = "gasUsed", IsRequired = true, EmitDefaultValue = true)]
        public string GasUsed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Stat {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  GasUsed: ").Append(GasUsed).Append("\n");
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
            return this.Equals(input as Stat);
        }

        /// <summary>
        /// Returns true if Stat instances are equal
        /// </summary>
        /// <param name="input">Instance of Stat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Stat input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Successful == input.Successful ||
                    this.Successful.Equals(input.Successful)
                ) && 
                (
                    this.GasUsed == input.GasUsed ||
                    (this.GasUsed != null &&
                    this.GasUsed.Equals(input.GasUsed))
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
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                hashCode = (hashCode * 59) + this.Successful.GetHashCode();
                if (this.GasUsed != null)
                {
                    hashCode = (hashCode * 59) + this.GasUsed.GetHashCode();
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
