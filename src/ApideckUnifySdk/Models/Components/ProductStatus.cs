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
    /// The current status of the product (active or archived).
    /// </summary>
    public enum ProductStatus
    {
        [JsonProperty("active")]
        Active,
        [JsonProperty("archived")]
        Archived,
    }

    public static class ProductStatusExtension
    {
        public static string Value(this ProductStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ProductStatus ToEnum(this string value)
        {
            foreach(var field in typeof(ProductStatus).GetFields())
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

                    if (enumVal is ProductStatus)
                    {
                        return (ProductStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ProductStatus");
        }
    }

}