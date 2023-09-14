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
    /// Defines SponsorSchema.CHARGE_CUSTOM_TOKENS
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SponsorSchemaCHARGECUSTOMTOKENS
    {
        /// <summary>
        /// Enum ChargeCustomTokens for value: charge_custom_tokens
        /// </summary>
        [EnumMember(Value = "charge_custom_tokens")]
        ChargeCustomTokens = 1

    }

}
