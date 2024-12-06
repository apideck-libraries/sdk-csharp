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
    /// The type of request
    /// </summary>
    public enum RequestType
    {
        [JsonProperty("vacation")]
        Vacation,
        [JsonProperty("sick")]
        Sick,
        [JsonProperty("personal")]
        Personal,
        [JsonProperty("jury_duty")]
        JuryDuty,
        [JsonProperty("volunteer")]
        Volunteer,
        [JsonProperty("bereavement")]
        Bereavement,
        [JsonProperty("other")]
        Other,
    }

    public static class RequestTypeExtension
    {
        public static string Value(this RequestType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static RequestType ToEnum(this string value)
        {
            foreach(var field in typeof(RequestType).GetFields())
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

                    if (enumVal is RequestType)
                    {
                        return (RequestType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum RequestType");
        }
    }

}