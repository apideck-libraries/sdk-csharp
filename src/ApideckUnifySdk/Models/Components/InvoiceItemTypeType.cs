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
    /// Item type
    /// </summary>
    public enum InvoiceItemTypeType
    {
        [JsonProperty("inventory")]
        Inventory,
        [JsonProperty("service")]
        Service,
        [JsonProperty("other")]
        Other,
    }

    public static class InvoiceItemTypeTypeExtension
    {
        public static string Value(this InvoiceItemTypeType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static InvoiceItemTypeType ToEnum(this string value)
        {
            foreach(var field in typeof(InvoiceItemTypeType).GetFields())
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

                    if (enumVal is InvoiceItemTypeType)
                    {
                        return (InvoiceItemTypeType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum InvoiceItemTypeType");
        }
    }

}