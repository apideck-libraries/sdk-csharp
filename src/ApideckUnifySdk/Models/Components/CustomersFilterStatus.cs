//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace ApideckUnifySdk.Models.Components
{
    using ApideckUnifySdk.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Status of customer to filter on
    /// </summary>
    public enum CustomersFilterStatus
    {
        [JsonProperty("active")]
        Active,
        [JsonProperty("inactive")]
        Inactive,
        [JsonProperty("archived")]
        Archived,
        [JsonProperty("all")]
        All,
    }

    public static class CustomersFilterStatusExtension
    {
        public static string Value(this CustomersFilterStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static CustomersFilterStatus ToEnum(this string value)
        {
            foreach(var field in typeof(CustomersFilterStatus).GetFields())
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

                    if (enumVal is CustomersFilterStatus)
                    {
                        return (CustomersFilterStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum CustomersFilterStatus");
        }
    }

}