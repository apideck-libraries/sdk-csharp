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
    /// The gender of the contact.
    /// </summary>
    public enum ContactGender
    {
        [JsonProperty("male")]
        Male,
        [JsonProperty("female")]
        Female,
        [JsonProperty("unisex")]
        Unisex,
    }

    public static class ContactGenderExtension
    {
        public static string Value(this ContactGender value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ContactGender ToEnum(this string value)
        {
            foreach(var field in typeof(ContactGender).GetFields())
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

                    if (enumVal is ContactGender)
                    {
                        return (ContactGender)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ContactGender");
        }
    }

}