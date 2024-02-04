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
    /// ResponseResponse
    /// </summary>
    [DataContract(Name = "ResponseResponse")]
    public partial class ResponseResponse : IEquatable<ResponseResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseResponse" /> class.
        /// </summary>
        /// <param name="createdAt">The unix timestamp in seconds when the transactionIntent was created. (required).</param>
        /// <param name="blockNumber">The block height (number) of the block including the transaction of this log..</param>
        /// <param name="transactionHash">The transaction hash of the transaction of this log..</param>
        /// <param name="l1GasUsed">The l1 gas used by the transaction of this log..</param>
        /// <param name="gasUsed">The gas used by the transaction of this log..</param>
        /// <param name="gasFee">The gas fee by the transaction of this log..</param>
        /// <param name="l1GasFee">The l1 gas fee by the transaction of this log..</param>
        /// <param name="status">The status of the transaction of this log..</param>
        /// <param name="logs">The logs of the transaction of this log..</param>
        /// <param name="to">The address of the contract of this log..</param>
        /// <param name="error">The error of the transaction of this log..</param>
        public ResponseResponse(int createdAt = default(int), int blockNumber = default(int), string transactionHash = default(string), string l1GasUsed = default(string), long gasUsed = default(long), string gasFee = default(string), string l1GasFee = default(string), int status = default(int), List<Log> logs = default(List<Log>), string to = default(string), Object error = default(Object))
        {
            this.CreatedAt = createdAt;
            this.BlockNumber = blockNumber;
            this.TransactionHash = transactionHash;
            this.L1GasUsed = l1GasUsed;
            this.GasUsed = gasUsed;
            this.GasFee = gasFee;
            this.L1GasFee = l1GasFee;
            this.Status = status;
            this.Logs = logs;
            this.To = to;
            this.Error = error;
        }

        /// <summary>
        /// The unix timestamp in seconds when the transactionIntent was created.
        /// </summary>
        /// <value>The unix timestamp in seconds when the transactionIntent was created.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public int CreatedAt { get; set; }

        /// <summary>
        /// The block height (number) of the block including the transaction of this log.
        /// </summary>
        /// <value>The block height (number) of the block including the transaction of this log.</value>
        [DataMember(Name = "blockNumber", EmitDefaultValue = false)]
        public int BlockNumber { get; set; }

        /// <summary>
        /// The transaction hash of the transaction of this log.
        /// </summary>
        /// <value>The transaction hash of the transaction of this log.</value>
        [DataMember(Name = "transactionHash", EmitDefaultValue = false)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// The l1 gas used by the transaction of this log.
        /// </summary>
        /// <value>The l1 gas used by the transaction of this log.</value>
        [DataMember(Name = "l1GasUsed", EmitDefaultValue = false)]
        public string L1GasUsed { get; set; }

        /// <summary>
        /// The gas used by the transaction of this log.
        /// </summary>
        /// <value>The gas used by the transaction of this log.</value>
        [DataMember(Name = "gasUsed", EmitDefaultValue = false)]
        public long GasUsed { get; set; }

        /// <summary>
        /// The gas fee by the transaction of this log.
        /// </summary>
        /// <value>The gas fee by the transaction of this log.</value>
        [DataMember(Name = "gasFee", EmitDefaultValue = false)]
        public string GasFee { get; set; }

        /// <summary>
        /// The l1 gas fee by the transaction of this log.
        /// </summary>
        /// <value>The l1 gas fee by the transaction of this log.</value>
        [DataMember(Name = "l1GasFee", EmitDefaultValue = false)]
        public string L1GasFee { get; set; }

        /// <summary>
        /// The status of the transaction of this log.
        /// </summary>
        /// <value>The status of the transaction of this log.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// The logs of the transaction of this log.
        /// </summary>
        /// <value>The logs of the transaction of this log.</value>
        [DataMember(Name = "logs", EmitDefaultValue = false)]
        public List<Log> Logs { get; set; }

        /// <summary>
        /// The address of the contract of this log.
        /// </summary>
        /// <value>The address of the contract of this log.</value>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// The error of the transaction of this log.
        /// </summary>
        /// <value>The error of the transaction of this log.</value>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public Object Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseResponse {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  L1GasUsed: ").Append(L1GasUsed).Append("\n");
            sb.Append("  GasUsed: ").Append(GasUsed).Append("\n");
            sb.Append("  GasFee: ").Append(GasFee).Append("\n");
            sb.Append("  L1GasFee: ").Append(L1GasFee).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as ResponseResponse);
        }

        /// <summary>
        /// Returns true if ResponseResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.BlockNumber == input.BlockNumber ||
                    this.BlockNumber.Equals(input.BlockNumber)
                ) && 
                (
                    this.TransactionHash == input.TransactionHash ||
                    (this.TransactionHash != null &&
                    this.TransactionHash.Equals(input.TransactionHash))
                ) && 
                (
                    this.L1GasUsed == input.L1GasUsed ||
                    (this.L1GasUsed != null &&
                    this.L1GasUsed.Equals(input.L1GasUsed))
                ) && 
                (
                    this.GasUsed == input.GasUsed ||
                    this.GasUsed.Equals(input.GasUsed)
                ) && 
                (
                    this.GasFee == input.GasFee ||
                    (this.GasFee != null &&
                    this.GasFee.Equals(input.GasFee))
                ) && 
                (
                    this.L1GasFee == input.L1GasFee ||
                    (this.L1GasFee != null &&
                    this.L1GasFee.Equals(input.L1GasFee))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Logs == input.Logs ||
                    this.Logs != null &&
                    input.Logs != null &&
                    this.Logs.SequenceEqual(input.Logs)
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.BlockNumber.GetHashCode();
                if (this.TransactionHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionHash.GetHashCode();
                }
                if (this.L1GasUsed != null)
                {
                    hashCode = (hashCode * 59) + this.L1GasUsed.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GasUsed.GetHashCode();
                if (this.GasFee != null)
                {
                    hashCode = (hashCode * 59) + this.GasFee.GetHashCode();
                }
                if (this.L1GasFee != null)
                {
                    hashCode = (hashCode * 59) + this.L1GasFee.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Logs != null)
                {
                    hashCode = (hashCode * 59) + this.Logs.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
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
