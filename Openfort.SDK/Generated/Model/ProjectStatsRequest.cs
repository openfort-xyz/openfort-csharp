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
    /// ProjectStatsRequest
    /// </summary>
    [DataContract(Name = "ProjectStatsRequest")]
    public partial class ProjectStatsRequest : IEquatable<ProjectStatsRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines TimeFrame
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeFrameEnum
        {
            /// <summary>
            /// Enum Day for value: day
            /// </summary>
            [EnumMember(Value = "day")]
            Day = 1,

            /// <summary>
            /// Enum Week for value: week
            /// </summary>
            [EnumMember(Value = "week")]
            Week = 2,

            /// <summary>
            /// Enum Month for value: month
            /// </summary>
            [EnumMember(Value = "month")]
            Month = 3,

            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 4

        }


        /// <summary>
        /// Gets or Sets TimeFrame
        /// </summary>
        [DataMember(Name = "timeFrame", IsRequired = true, EmitDefaultValue = true)]
        public TimeFrameEnum TimeFrame { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectStatsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatsRequest" /> class.
        /// </summary>
        /// <param name="timeFrame">timeFrame (required).</param>
        public ProjectStatsRequest(TimeFrameEnum timeFrame = default(TimeFrameEnum))
        {
            this.TimeFrame = timeFrame;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectStatsRequest {\n");
            sb.Append("  TimeFrame: ").Append(TimeFrame).Append("\n");
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
            return this.Equals(input as ProjectStatsRequest);
        }

        /// <summary>
        /// Returns true if ProjectStatsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectStatsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectStatsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TimeFrame == input.TimeFrame ||
                    this.TimeFrame.Equals(input.TimeFrame)
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
                hashCode = (hashCode * 59) + this.TimeFrame.GetHashCode();
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