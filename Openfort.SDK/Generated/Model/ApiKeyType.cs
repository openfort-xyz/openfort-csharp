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
    /// Defines ApiKeyType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApiKeyType
    {
        /// <summary>
        /// Enum Pk for value: pk
        /// </summary>
        [EnumMember(Value = "pk")]
        Pk = 1,

        /// <summary>
        /// Enum Sk for value: sk
        /// </summary>
        [EnumMember(Value = "sk")]
        Sk = 2,

        /// <summary>
        /// Enum PkShield for value: pk_shield
        /// </summary>
        [EnumMember(Value = "pk_shield")]
        PkShield = 3,

        /// <summary>
        /// Enum SkShield for value: sk_shield
        /// </summary>
        [EnumMember(Value = "sk_shield")]
        SkShield = 4

    }

}
