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
    /// The current state of the Integration.
    /// </summary>
    public enum IntegrationState
    {
        [JsonProperty("disabled")]
        Disabled,
        [JsonProperty("needs_configuration")]
        NeedsConfiguration,
        [JsonProperty("configured")]
        Configured,
    }

    public static class IntegrationStateExtension
    {
        public static string Value(this IntegrationState value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static IntegrationState ToEnum(this string value)
        {
            foreach(var field in typeof(IntegrationState).GetFields())
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

                    if (enumVal is IntegrationState)
                    {
                        return (IntegrationState)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum IntegrationState");
        }
    }

}