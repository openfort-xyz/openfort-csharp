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
    /// QuoteExchangeResult
    /// </summary>
    [DataContract(Name = "QuoteExchangeResult")]
    public partial class QuoteExchangeResult : IEquatable<QuoteExchangeResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteExchangeResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteExchangeResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteExchangeResult" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="amountWithMaxSlippage">amountWithMaxSlippage (required).</param>
        /// <param name="slippage">slippage (required).</param>
        /// <param name="fees">fees (required).</param>
        /// <param name="estimatedTXGasFee">estimatedTXGasFee (required).</param>
        /// <param name="estimatedTXGasFeeUSD">estimatedTXGasFeeUSD (required).</param>
        /// <param name="estimatedTXGasFeeToken">estimatedTXGasFeeToken.</param>
        public QuoteExchangeResult(Amount amount = default(Amount), Amount amountWithMaxSlippage = default(Amount), double slippage = default(double), List<Fee> fees = default(List<Fee>), string estimatedTXGasFee = default(string), string estimatedTXGasFeeUSD = default(string), string estimatedTXGasFeeToken = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for QuoteExchangeResult and cannot be null");
            }
            this.Amount = amount;
            // to ensure "amountWithMaxSlippage" is required (not null)
            if (amountWithMaxSlippage == null)
            {
                throw new ArgumentNullException("amountWithMaxSlippage is a required property for QuoteExchangeResult and cannot be null");
            }
            this.AmountWithMaxSlippage = amountWithMaxSlippage;
            this.Slippage = slippage;
            // to ensure "fees" is required (not null)
            if (fees == null)
            {
                throw new ArgumentNullException("fees is a required property for QuoteExchangeResult and cannot be null");
            }
            this.Fees = fees;
            // to ensure "estimatedTXGasFee" is required (not null)
            if (estimatedTXGasFee == null)
            {
                throw new ArgumentNullException("estimatedTXGasFee is a required property for QuoteExchangeResult and cannot be null");
            }
            this.EstimatedTXGasFee = estimatedTXGasFee;
            // to ensure "estimatedTXGasFeeUSD" is required (not null)
            if (estimatedTXGasFeeUSD == null)
            {
                throw new ArgumentNullException("estimatedTXGasFeeUSD is a required property for QuoteExchangeResult and cannot be null");
            }
            this.EstimatedTXGasFeeUSD = estimatedTXGasFeeUSD;
            this.EstimatedTXGasFeeToken = estimatedTXGasFeeToken;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or Sets AmountWithMaxSlippage
        /// </summary>
        [DataMember(Name = "amountWithMaxSlippage", IsRequired = true, EmitDefaultValue = true)]
        public Amount AmountWithMaxSlippage { get; set; }

        /// <summary>
        /// Gets or Sets Slippage
        /// </summary>
        [DataMember(Name = "slippage", IsRequired = true, EmitDefaultValue = true)]
        public double Slippage { get; set; }

        /// <summary>
        /// Gets or Sets Fees
        /// </summary>
        [DataMember(Name = "fees", IsRequired = true, EmitDefaultValue = true)]
        public List<Fee> Fees { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedTXGasFee
        /// </summary>
        [DataMember(Name = "estimatedTXGasFee", IsRequired = true, EmitDefaultValue = true)]
        public string EstimatedTXGasFee { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedTXGasFeeUSD
        /// </summary>
        [DataMember(Name = "estimatedTXGasFeeUSD", IsRequired = true, EmitDefaultValue = true)]
        public string EstimatedTXGasFeeUSD { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedTXGasFeeToken
        /// </summary>
        [DataMember(Name = "estimatedTXGasFeeToken", EmitDefaultValue = false)]
        public string EstimatedTXGasFeeToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteExchangeResult {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AmountWithMaxSlippage: ").Append(AmountWithMaxSlippage).Append("\n");
            sb.Append("  Slippage: ").Append(Slippage).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  EstimatedTXGasFee: ").Append(EstimatedTXGasFee).Append("\n");
            sb.Append("  EstimatedTXGasFeeUSD: ").Append(EstimatedTXGasFeeUSD).Append("\n");
            sb.Append("  EstimatedTXGasFeeToken: ").Append(EstimatedTXGasFeeToken).Append("\n");
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
            return this.Equals(input as QuoteExchangeResult);
        }

        /// <summary>
        /// Returns true if QuoteExchangeResult instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteExchangeResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteExchangeResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.AmountWithMaxSlippage == input.AmountWithMaxSlippage ||
                    (this.AmountWithMaxSlippage != null &&
                    this.AmountWithMaxSlippage.Equals(input.AmountWithMaxSlippage))
                ) && 
                (
                    this.Slippage == input.Slippage ||
                    this.Slippage.Equals(input.Slippage)
                ) && 
                (
                    this.Fees == input.Fees ||
                    this.Fees != null &&
                    input.Fees != null &&
                    this.Fees.SequenceEqual(input.Fees)
                ) && 
                (
                    this.EstimatedTXGasFee == input.EstimatedTXGasFee ||
                    (this.EstimatedTXGasFee != null &&
                    this.EstimatedTXGasFee.Equals(input.EstimatedTXGasFee))
                ) && 
                (
                    this.EstimatedTXGasFeeUSD == input.EstimatedTXGasFeeUSD ||
                    (this.EstimatedTXGasFeeUSD != null &&
                    this.EstimatedTXGasFeeUSD.Equals(input.EstimatedTXGasFeeUSD))
                ) && 
                (
                    this.EstimatedTXGasFeeToken == input.EstimatedTXGasFeeToken ||
                    (this.EstimatedTXGasFeeToken != null &&
                    this.EstimatedTXGasFeeToken.Equals(input.EstimatedTXGasFeeToken))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.AmountWithMaxSlippage != null)
                {
                    hashCode = (hashCode * 59) + this.AmountWithMaxSlippage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Slippage.GetHashCode();
                if (this.Fees != null)
                {
                    hashCode = (hashCode * 59) + this.Fees.GetHashCode();
                }
                if (this.EstimatedTXGasFee != null)
                {
                    hashCode = (hashCode * 59) + this.EstimatedTXGasFee.GetHashCode();
                }
                if (this.EstimatedTXGasFeeUSD != null)
                {
                    hashCode = (hashCode * 59) + this.EstimatedTXGasFeeUSD.GetHashCode();
                }
                if (this.EstimatedTXGasFeeToken != null)
                {
                    hashCode = (hashCode * 59) + this.EstimatedTXGasFeeToken.GetHashCode();
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