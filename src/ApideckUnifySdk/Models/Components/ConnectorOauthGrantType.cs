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
    /// OAuth grant type used by the connector. More info: https://oauth.net/2/grant-types
    /// </summary>
    public enum ConnectorOauthGrantType
    {
        [JsonProperty("authorization_code")]
        AuthorizationCode,
        [JsonProperty("client_credentials")]
        ClientCredentials,
        [JsonProperty("password")]
        Password,
    }

    public static class ConnectorOauthGrantTypeExtension
    {
        public static string Value(this ConnectorOauthGrantType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ConnectorOauthGrantType ToEnum(this string value)
        {
            foreach(var field in typeof(ConnectorOauthGrantType).GetFields())
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

                    if (enumVal is ConnectorOauthGrantType)
                    {
                        return (ConnectorOauthGrantType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ConnectorOauthGrantType");
        }
    }

}