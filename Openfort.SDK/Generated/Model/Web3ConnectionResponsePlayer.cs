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
    /// The player ID (starts with pla_).
    /// </summary>
    [JsonConverter(typeof(Web3ConnectionResponsePlayerJsonConverter))]
    [DataContract(Name = "Web3ConnectionResponse_player")]
    public partial class Web3ConnectionResponsePlayer : AbstractOpenAPISchema, IEquatable<Web3ConnectionResponsePlayer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Web3ConnectionResponsePlayer" /> class
        /// with the <see cref="Player" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Player.</param>
        public Web3ConnectionResponsePlayer(Player actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Web3ConnectionResponsePlayer" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public Web3ConnectionResponsePlayer(string actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
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
                if (value.GetType() == typeof(Player))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Player, string");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Player`. If the actual instance is not `Player`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Player</returns>
        public Player GetPlayer()
        {
            return (Player)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `string`. If the actual instance is not `string`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of string</returns>
        public string GetString()
        {
            return (string)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Web3ConnectionResponsePlayer {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Web3ConnectionResponsePlayer.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Web3ConnectionResponsePlayer
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Web3ConnectionResponsePlayer</returns>
        public static Web3ConnectionResponsePlayer FromJson(string jsonString)
        {
            Web3ConnectionResponsePlayer newWeb3ConnectionResponsePlayer = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newWeb3ConnectionResponsePlayer;
            }

            try
            {
                newWeb3ConnectionResponsePlayer = new Web3ConnectionResponsePlayer(JsonConvert.DeserializeObject<Player>(jsonString, Web3ConnectionResponsePlayer.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newWeb3ConnectionResponsePlayer;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Player: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newWeb3ConnectionResponsePlayer = new Web3ConnectionResponsePlayer(JsonConvert.DeserializeObject<string>(jsonString, Web3ConnectionResponsePlayer.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newWeb3ConnectionResponsePlayer;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into string: {1}", jsonString, exception.ToString()));
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
            return this.Equals(input as Web3ConnectionResponsePlayer);
        }

        /// <summary>
        /// Returns true if Web3ConnectionResponsePlayer instances are equal
        /// </summary>
        /// <param name="input">Instance of Web3ConnectionResponsePlayer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Web3ConnectionResponsePlayer input)
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
    /// Custom JSON converter for Web3ConnectionResponsePlayer
    /// </summary>
    public class Web3ConnectionResponsePlayerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Web3ConnectionResponsePlayer).GetMethod("ToJson").Invoke(value, null)));
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
                return Web3ConnectionResponsePlayer.FromJson(JObject.Load(reader).ToString(Formatting.None));
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