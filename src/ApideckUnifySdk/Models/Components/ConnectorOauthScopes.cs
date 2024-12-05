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
    
    /// <summary>
    /// OAuth scopes required for the connector. Add these scopes to your OAuth app.
    /// </summary>
    public class ConnectorOauthScopes
    {

        /// <summary>
        /// ID of the OAuth scope.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Label of the OAuth scope.
        /// </summary>
        [JsonProperty("label")]
        public string? Label { get; set; }
    }
}