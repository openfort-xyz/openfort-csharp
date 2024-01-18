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
    /// CreateContractRequest
    /// </summary>
    [DataContract(Name = "CreateContractRequest")]
    public partial class CreateContractRequest : IEquatable<CreateContractRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContractRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateContractRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContractRequest" /> class.
        /// </summary>
        /// <param name="name">Specifies the name of the contract (Only for display purposes). (required).</param>
        /// <param name="chainId">Specifies the chain ID of the contract. Must be a [supported chain](/chains). (required).</param>
        /// <param name="address">Specifies the address of the contract. (required).</param>
        /// <param name="abi">Specifies the ABI of the contract..</param>
        /// <param name="publicVerification">Specifies whether to verify the contract publicly..</param>
        public CreateContractRequest(string name = default(string), int chainId = default(int), string address = default(string), List<Abi> abi = default(List<Abi>), bool publicVerification = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateContractRequest and cannot be null");
            }
            this.Name = name;
            this.ChainId = chainId;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for CreateContractRequest and cannot be null");
            }
            this.Address = address;
            this.Abi = abi;
            this.PublicVerification = publicVerification;
        }

        /// <summary>
        /// Specifies the name of the contract (Only for display purposes).
        /// </summary>
        /// <value>Specifies the name of the contract (Only for display purposes).</value>
        /// <example>&quot;NFT Contract&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the chain ID of the contract. Must be a [supported chain](/chains).
        /// </summary>
        /// <value>Specifies the chain ID of the contract. Must be a [supported chain](/chains).</value>
        /// <example>80001</example>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public int ChainId { get; set; }

        /// <summary>
        /// Specifies the address of the contract.
        /// </summary>
        /// <value>Specifies the address of the contract.</value>
        /// <example>&quot;0x742e6e61d760164d56f44801054bcf40fa821d97&quot;</example>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Specifies the ABI of the contract.
        /// </summary>
        /// <value>Specifies the ABI of the contract.</value>
        [DataMember(Name = "abi", EmitDefaultValue = false)]
        public List<Abi> Abi { get; set; }

        /// <summary>
        /// Specifies whether to verify the contract publicly.
        /// </summary>
        /// <value>Specifies whether to verify the contract publicly.</value>
        /// <example>false</example>
        [DataMember(Name = "publicVerification", EmitDefaultValue = true)]
        public bool PublicVerification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateContractRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Abi: ").Append(Abi).Append("\n");
            sb.Append("  PublicVerification: ").Append(PublicVerification).Append("\n");
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
            return this.Equals(input as CreateContractRequest);
        }

        /// <summary>
        /// Returns true if CreateContractRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateContractRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateContractRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Abi == input.Abi ||
                    this.Abi != null &&
                    input.Abi != null &&
                    this.Abi.SequenceEqual(input.Abi)
                ) && 
                (
                    this.PublicVerification == input.PublicVerification ||
                    this.PublicVerification.Equals(input.PublicVerification)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Abi != null)
                {
                    hashCode = (hashCode * 59) + this.Abi.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PublicVerification.GetHashCode();
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
