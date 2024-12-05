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
    /// Type of authorization used by the connector
    /// </summary>
    public enum AuthType
    {
        [JsonProperty("oauth2")]
        Oauth2,
        [JsonProperty("apiKey")]
        ApiKey,
        [JsonProperty("basic")]
        Basic,
        [JsonProperty("custom")]
        Custom,
        [JsonProperty("none")]
        None,
    }

    public static class AuthTypeExtension
    {
        public static string Value(this AuthType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AuthType ToEnum(this string value)
        {
            foreach(var field in typeof(AuthType).GetFields())
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

                    if (enumVal is AuthType)
                    {
                        return (AuthType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum AuthType");
        }
    }

}