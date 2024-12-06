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
    using ApideckUnifySdk.Models.Components;
    using ApideckUnifySdk.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class UnifiedApis
    {

        /// <summary>
        /// Name of Apideck Unified API
        /// </summary>
        [JsonProperty("id")]
        public UnifiedApiId? Id { get; set; }

        /// <summary>
        /// Name of the API.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Indicates whether a connector only supports authentication. In this case the connector is not mapped to a Unified API, but can be used with the Proxy API
        /// </summary>
        [JsonProperty("auth_only")]
        public bool? AuthOnly { get; set; }

        [JsonProperty("oauth_scopes")]
        public List<ConnectorOauthScopes>? OauthScopes { get; set; }

        /// <summary>
        /// List of resources that are supported on the connector.
        /// </summary>
        [JsonProperty("supported_resources")]
        public List<LinkedConnectorResource>? SupportedResources { get; set; }

        /// <summary>
        /// List of resources that are not supported on the downstream.
        /// </summary>
        [JsonProperty("downstream_unsupported_resources")]
        public List<string>? DownstreamUnsupportedResources { get; set; }

        /// <summary>
        /// List of events that are supported on the connector for this Unified API.
        /// </summary>
        [JsonProperty("supported_events")]
        public List<ConnectorEvent>? SupportedEvents { get; set; }
    }
}