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
    /// GasReportDataInner
    /// </summary>
    [DataContract(Name = "GasReport_data_inner")]
    public partial class GasReportDataInner : IEquatable<GasReportDataInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GasReportDataInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GasReportDataInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GasReportDataInner" /> class.
        /// </summary>
        /// <param name="transactionIntents">transactionIntents (required).</param>
        /// <param name="totalTransactionFeeInUSD">totalTransactionFeeInUSD (required).</param>
        /// <param name="totalTransactionFee">totalTransactionFee (required).</param>
        /// <param name="averageTransactionFee">averageTransactionFee (required).</param>
        /// <param name="period">period (required).</param>
        /// <param name="periodNumber">periodNumber (required).</param>
        public GasReportDataInner(List<GasReportDataInnerTransactionIntentsInner> transactionIntents = default(List<GasReportDataInnerTransactionIntentsInner>), string totalTransactionFeeInUSD = default(string), string totalTransactionFee = default(string), string averageTransactionFee = default(string), GasReportDataInnerPeriod period = default(GasReportDataInnerPeriod), double periodNumber = default(double))
        {
            // to ensure "transactionIntents" is required (not null)
            if (transactionIntents == null)
            {
                throw new ArgumentNullException("transactionIntents is a required property for GasReportDataInner and cannot be null");
            }
            this.TransactionIntents = transactionIntents;
            // to ensure "totalTransactionFeeInUSD" is required (not null)
            if (totalTransactionFeeInUSD == null)
            {
                throw new ArgumentNullException("totalTransactionFeeInUSD is a required property for GasReportDataInner and cannot be null");
            }
            this.TotalTransactionFeeInUSD = totalTransactionFeeInUSD;
            // to ensure "totalTransactionFee" is required (not null)
            if (totalTransactionFee == null)
            {
                throw new ArgumentNullException("totalTransactionFee is a required property for GasReportDataInner and cannot be null");
            }
            this.TotalTransactionFee = totalTransactionFee;
            // to ensure "averageTransactionFee" is required (not null)
            if (averageTransactionFee == null)
            {
                throw new ArgumentNullException("averageTransactionFee is a required property for GasReportDataInner and cannot be null");
            }
            this.AverageTransactionFee = averageTransactionFee;
            // to ensure "period" is required (not null)
            if (period == null)
            {
                throw new ArgumentNullException("period is a required property for GasReportDataInner and cannot be null");
            }
            this.Period = period;
            this.PeriodNumber = periodNumber;
        }

        /// <summary>
        /// Gets or Sets TransactionIntents
        /// </summary>
        [DataMember(Name = "transactionIntents", IsRequired = true, EmitDefaultValue = true)]
        public List<GasReportDataInnerTransactionIntentsInner> TransactionIntents { get; set; }

        /// <summary>
        /// Gets or Sets TotalTransactionFeeInUSD
        /// </summary>
        [DataMember(Name = "totalTransactionFeeInUSD", IsRequired = true, EmitDefaultValue = true)]
        public string TotalTransactionFeeInUSD { get; set; }

        /// <summary>
        /// Gets or Sets TotalTransactionFee
        /// </summary>
        [DataMember(Name = "totalTransactionFee", IsRequired = true, EmitDefaultValue = true)]
        public string TotalTransactionFee { get; set; }

        /// <summary>
        /// Gets or Sets AverageTransactionFee
        /// </summary>
        [DataMember(Name = "averageTransactionFee", IsRequired = true, EmitDefaultValue = true)]
        public string AverageTransactionFee { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", IsRequired = true, EmitDefaultValue = true)]
        public GasReportDataInnerPeriod Period { get; set; }

        /// <summary>
        /// Gets or Sets PeriodNumber
        /// </summary>
        [DataMember(Name = "periodNumber", IsRequired = true, EmitDefaultValue = true)]
        public double PeriodNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GasReportDataInner {\n");
            sb.Append("  TransactionIntents: ").Append(TransactionIntents).Append("\n");
            sb.Append("  TotalTransactionFeeInUSD: ").Append(TotalTransactionFeeInUSD).Append("\n");
            sb.Append("  TotalTransactionFee: ").Append(TotalTransactionFee).Append("\n");
            sb.Append("  AverageTransactionFee: ").Append(AverageTransactionFee).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  PeriodNumber: ").Append(PeriodNumber).Append("\n");
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
            return this.Equals(input as GasReportDataInner);
        }

        /// <summary>
        /// Returns true if GasReportDataInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GasReportDataInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GasReportDataInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionIntents == input.TransactionIntents ||
                    this.TransactionIntents != null &&
                    input.TransactionIntents != null &&
                    this.TransactionIntents.SequenceEqual(input.TransactionIntents)
                ) && 
                (
                    this.TotalTransactionFeeInUSD == input.TotalTransactionFeeInUSD ||
                    (this.TotalTransactionFeeInUSD != null &&
                    this.TotalTransactionFeeInUSD.Equals(input.TotalTransactionFeeInUSD))
                ) && 
                (
                    this.TotalTransactionFee == input.TotalTransactionFee ||
                    (this.TotalTransactionFee != null &&
                    this.TotalTransactionFee.Equals(input.TotalTransactionFee))
                ) && 
                (
                    this.AverageTransactionFee == input.AverageTransactionFee ||
                    (this.AverageTransactionFee != null &&
                    this.AverageTransactionFee.Equals(input.AverageTransactionFee))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.PeriodNumber == input.PeriodNumber ||
                    this.PeriodNumber.Equals(input.PeriodNumber)
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
                if (this.TransactionIntents != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionIntents.GetHashCode();
                }
                if (this.TotalTransactionFeeInUSD != null)
                {
                    hashCode = (hashCode * 59) + this.TotalTransactionFeeInUSD.GetHashCode();
                }
                if (this.TotalTransactionFee != null)
                {
                    hashCode = (hashCode * 59) + this.TotalTransactionFee.GetHashCode();
                }
                if (this.AverageTransactionFee != null)
                {
                    hashCode = (hashCode * 59) + this.AverageTransactionFee.GetHashCode();
                }
                if (this.Period != null)
                {
                    hashCode = (hashCode * 59) + this.Period.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PeriodNumber.GetHashCode();
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
