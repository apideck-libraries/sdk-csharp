//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Apideck.Unify.SDK.Models.Components
{
    using Apideck.Unify.SDK.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The employment status of the employee, indicating whether they are currently employed, inactive, terminated, or in another status.
    /// </summary>
    public enum EmploymentStatus
    {
        [JsonProperty("active")]
        Active,
        [JsonProperty("inactive")]
        Inactive,
        [JsonProperty("terminated")]
        Terminated,
        [JsonProperty("other")]
        Other,
    }

    public static class EmploymentStatusExtension
    {
        public static string Value(this EmploymentStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static EmploymentStatus ToEnum(this string value)
        {
            foreach(var field in typeof(EmploymentStatus).GetFields())
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

                    if (enumVal is EmploymentStatus)
                    {
                        return (EmploymentStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum EmploymentStatus");
        }
    }

}