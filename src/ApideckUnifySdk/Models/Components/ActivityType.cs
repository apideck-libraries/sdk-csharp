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
    /// The type of the activity
    /// </summary>
    public enum ActivityType
    {
        [JsonProperty("call")]
        Call,
        [JsonProperty("meeting")]
        Meeting,
        [JsonProperty("email")]
        Email,
        [JsonProperty("note")]
        Note,
        [JsonProperty("task")]
        Task,
        [JsonProperty("deadline")]
        Deadline,
        [JsonProperty("send-letter")]
        SendLetter,
        [JsonProperty("send-quote")]
        SendQuote,
        [JsonProperty("other")]
        Other,
    }

    public static class ActivityTypeExtension
    {
        public static string Value(this ActivityType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ActivityType ToEnum(this string value)
        {
            foreach(var field in typeof(ActivityType).GetFields())
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

                    if (enumVal is ActivityType)
                    {
                        return (ActivityType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ActivityType");
        }
    }

}