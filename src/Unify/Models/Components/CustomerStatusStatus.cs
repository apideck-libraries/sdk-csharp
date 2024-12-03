//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Unify.Models.Components
{
    using Newtonsoft.Json;
    using System;
    using Unify.Utils;
    
    /// <summary>
    /// Customer status
    /// </summary>
    public enum CustomerStatusStatus
    {
        [JsonProperty("active")]
        Active,
        [JsonProperty("inactive")]
        Inactive,
        [JsonProperty("archived")]
        Archived,
        [JsonProperty("gdpr-erasure-request")]
        GdprErasureRequest,
        [JsonProperty("unknown")]
        Unknown,
    }

    public static class CustomerStatusStatusExtension
    {
        public static string Value(this CustomerStatusStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static CustomerStatusStatus ToEnum(this string value)
        {
            foreach(var field in typeof(CustomerStatusStatus).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is CustomerStatusStatus)
                    {
                        return (CustomerStatusStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum CustomerStatusStatus");
        }
    }

}