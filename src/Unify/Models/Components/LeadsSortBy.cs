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
    /// The field on which to sort the Leads
    /// </summary>
    public enum LeadsSortBy
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

    public static class LeadsSortByExtension
    {
        public static string Value(this LeadsSortBy value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static LeadsSortBy ToEnum(this string value)
        {
            foreach(var field in typeof(LeadsSortBy).GetFields())
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

                    if (enumVal is LeadsSortBy)
                    {
                        return (LeadsSortBy)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum LeadsSortBy");
        }
    }

}