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
    /// The status of the time off request.
    /// </summary>
    public enum TimeOffRequestStatusStatus
    {
        [JsonProperty("requested")]
        Requested,
        [JsonProperty("approved")]
        Approved,
        [JsonProperty("declined")]
        Declined,
        [JsonProperty("cancelled")]
        Cancelled,
        [JsonProperty("deleted")]
        Deleted,
        [JsonProperty("other")]
        Other,
    }

    public static class TimeOffRequestStatusStatusExtension
    {
        public static string Value(this TimeOffRequestStatusStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static TimeOffRequestStatusStatus ToEnum(this string value)
        {
            foreach(var field in typeof(TimeOffRequestStatusStatus).GetFields())
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

                    if (enumVal is TimeOffRequestStatusStatus)
                    {
                        return (TimeOffRequestStatusStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum TimeOffRequestStatusStatus");
        }
    }

}