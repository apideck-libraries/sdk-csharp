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
    /// The field on which to sort the Contacts
    /// </summary>
    public enum ContactsSortBy
    {
        [JsonProperty("created_at")]
        CreatedAt,
        [JsonProperty("updated_at")]
        UpdatedAt,
        [JsonProperty("name")]
        Name,
        [JsonProperty("first_name")]
        FirstName,
        [JsonProperty("last_name")]
        LastName,
        [JsonProperty("email")]
        Email,
    }

    public static class ContactsSortByExtension
    {
        public static string Value(this ContactsSortBy value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ContactsSortBy ToEnum(this string value)
        {
            foreach(var field in typeof(ContactsSortBy).GetFields())
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

                    if (enumVal is ContactsSortBy)
                    {
                        return (ContactsSortBy)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ContactsSortBy");
        }
    }

}