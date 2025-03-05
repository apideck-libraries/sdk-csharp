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
    /// The type of the contact.
    /// </summary>
    public enum Type
    {
        [JsonProperty("customer")]
        Customer,
        [JsonProperty("supplier")]
        Supplier,
        [JsonProperty("employee")]
        Employee,
        [JsonProperty("personal")]
        Personal,
    }

    public static class TypeExtension
    {
        public static string Value(this Type value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Type ToEnum(this string value)
        {
            foreach(var field in typeof(Type).GetFields())
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

                    if (enumVal is Type)
                    {
                        return (Type)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Type");
        }
    }

}