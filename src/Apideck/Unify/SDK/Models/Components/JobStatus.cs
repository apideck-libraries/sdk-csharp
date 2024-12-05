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
    /// The status of the job.
    /// </summary>
    public enum JobStatus
    {
        [JsonProperty("draft")]
        Draft,
        [JsonProperty("internal")]
        Internal,
        [JsonProperty("published")]
        Published,
        [JsonProperty("completed")]
        Completed,
        [JsonProperty("on-hold")]
        OnHold,
        [JsonProperty("private")]
        Private,
    }

    public static class JobStatusExtension
    {
        public static string Value(this JobStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static JobStatus ToEnum(this string value)
        {
            foreach(var field in typeof(JobStatus).GetFields())
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

                    if (enumVal is JobStatus)
                    {
                        return (JobStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum JobStatus");
        }
    }

}