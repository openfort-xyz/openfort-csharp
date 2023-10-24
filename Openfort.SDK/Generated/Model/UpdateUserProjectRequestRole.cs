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
using System.Reflection;

namespace Openfort.SDK.Model
{
    /// <summary>
    /// UpdateUserProjectRequestRole
    /// </summary>
    [JsonConverter(typeof(UpdateUserProjectRequestRoleJsonConverter))]
    [DataContract(Name = "UpdateUserProjectRequest_role")]
    public partial class UpdateUserProjectRequestRole : AbstractOpenAPISchema, IEquatable<UpdateUserProjectRequestRole>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserProjectRequestRole" /> class
        /// with the <see cref="UserProjectRoleMEMBER" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserProjectRoleMEMBER.</param>
        public UpdateUserProjectRequestRole(UserProjectRoleMEMBER actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserProjectRequestRole" /> class
        /// with the <see cref="UserProjectRoleADMIN" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserProjectRoleADMIN.</param>
        public UpdateUserProjectRequestRole(UserProjectRoleADMIN actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance;
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(UserProjectRoleADMIN))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UserProjectRoleMEMBER))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: UserProjectRoleADMIN, UserProjectRoleMEMBER");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `UserProjectRoleMEMBER`. If the actual instance is not `UserProjectRoleMEMBER`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserProjectRoleMEMBER</returns>
        public UserProjectRoleMEMBER GetUserProjectRoleMEMBER()
        {
            return (UserProjectRoleMEMBER)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UserProjectRoleADMIN`. If the actual instance is not `UserProjectRoleADMIN`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserProjectRoleADMIN</returns>
        public UserProjectRoleADMIN GetUserProjectRoleADMIN()
        {
            return (UserProjectRoleADMIN)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUserProjectRequestRole {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, UpdateUserProjectRequestRole.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of UpdateUserProjectRequestRole
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of UpdateUserProjectRequestRole</returns>
        public static UpdateUserProjectRequestRole FromJson(string jsonString)
        {
            UpdateUserProjectRequestRole newUpdateUserProjectRequestRole = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUpdateUserProjectRequestRole;
            }

            try
            {
                newUpdateUserProjectRequestRole = new UpdateUserProjectRequestRole(JsonConvert.DeserializeObject<UserProjectRoleADMIN>(jsonString, UpdateUserProjectRequestRole.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newUpdateUserProjectRequestRole;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserProjectRoleADMIN: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newUpdateUserProjectRequestRole = new UpdateUserProjectRequestRole(JsonConvert.DeserializeObject<UserProjectRoleMEMBER>(jsonString, UpdateUserProjectRequestRole.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newUpdateUserProjectRequestRole;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserProjectRoleMEMBER: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateUserProjectRequestRole);
        }

        /// <summary>
        /// Returns true if UpdateUserProjectRequestRole instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateUserProjectRequestRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateUserProjectRequestRole input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for UpdateUserProjectRequestRole
    /// </summary>
    public class UpdateUserProjectRequestRoleJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(UpdateUserProjectRequestRole).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return UpdateUserProjectRequestRole.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}