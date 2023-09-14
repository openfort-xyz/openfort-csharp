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
    /// Interaction
    /// </summary>
    [DataContract(Name = "Interaction")]
    public partial class Interaction : IEquatable<Interaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Interaction" /> class.
        /// </summary>
        /// <param name="to">The address of the contract..</param>
        /// <param name="contract">The contract interacting with.</param>
        /// <param name="value">The value of the transaction..</param>
        /// <param name="functionName">The function name of the contract..</param>
        /// <param name="functionArgs">The function arguments of the contract..</param>
        public Interaction(string to = default(string), string contract = default(string), string value = default(string), string functionName = default(string), List<Object> functionArgs = default(List<Object>))
        {
            this.To = to;
            this.Contract = contract;
            this.Value = value;
            this.FunctionName = functionName;
            this.FunctionArgs = functionArgs;
        }

        /// <summary>
        /// The address of the contract.
        /// </summary>
        /// <value>The address of the contract.</value>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// The contract interacting with
        /// </summary>
        /// <value>The contract interacting with</value>
        /// <example>&quot;con_...&quot;</example>
        [DataMember(Name = "contract", EmitDefaultValue = false)]
        public string Contract { get; set; }

        /// <summary>
        /// The value of the transaction.
        /// </summary>
        /// <value>The value of the transaction.</value>
        /// <example>&quot;100000000000000&quot;</example>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// The function name of the contract.
        /// </summary>
        /// <value>The function name of the contract.</value>
        /// <example>&quot;mint&quot;</example>
        [DataMember(Name = "functionName", EmitDefaultValue = false)]
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
            sb.Append("class Interaction {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as Interaction);
        }

        /// <summary>
        /// Returns true if Interaction instances are equal
        /// </summary>
        /// <param name="input">Instance of Interaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Interaction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
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
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
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
