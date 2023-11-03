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
    /// ContractReadQueries
    /// </summary>
    [DataContract(Name = "ContractReadQueries")]
    public partial class ContractReadQueries : IEquatable<ContractReadQueries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractReadQueries" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContractReadQueries() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractReadQueries" /> class.
        /// </summary>
        /// <param name="functionName">The function name of the contract. (required).</param>
        /// <param name="functionArgs">The function arguments of the contract..</param>
        public ContractReadQueries(string functionName = default(string), List<Object> functionArgs = default(List<Object>))
        {
            // to ensure "functionName" is required (not null)
            if (functionName == null)
            {
                throw new ArgumentNullException("functionName is a required property for ContractReadQueries and cannot be null");
            }
            this.FunctionName = functionName;
            this.FunctionArgs = functionArgs;
        }

        /// <summary>
        /// The function name of the contract.
        /// </summary>
        /// <value>The function name of the contract.</value>
        /// <example>&quot;mint&quot;</example>
        [DataMember(Name = "functionName", IsRequired = true, EmitDefaultValue = true)]
        public string FunctionName { get; set; }

        /// <summary>
        /// The function arguments of the contract.
        /// </summary>
        /// <value>The function arguments of the contract.</value>
        [DataMember(Name = "functionArgs", EmitDefaultValue = false)]
        public List<Object> FunctionArgs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContractReadQueries {\n");
            sb.Append("  FunctionName: ").Append(FunctionName).Append("\n");
            sb.Append("  FunctionArgs: ").Append(FunctionArgs).Append("\n");
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
            return this.Equals(input as ContractReadQueries);
        }

        /// <summary>
        /// Returns true if ContractReadQueries instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractReadQueries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractReadQueries input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FunctionName == input.FunctionName ||
                    (this.FunctionName != null &&
                    this.FunctionName.Equals(input.FunctionName))
                ) && 
                (
                    this.FunctionArgs == input.FunctionArgs ||
                    this.FunctionArgs != null &&
                    input.FunctionArgs != null &&
                    this.FunctionArgs.SequenceEqual(input.FunctionArgs)
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
                if (this.FunctionName != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionName.GetHashCode();
                }
                if (this.FunctionArgs != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionArgs.GetHashCode();
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
