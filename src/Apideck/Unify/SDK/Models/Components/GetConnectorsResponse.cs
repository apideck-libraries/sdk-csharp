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
    using Apideck.Unify.SDK.Models.Components;
    using Apideck.Unify.SDK.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// Connectors
    /// </summary>
    public class GetConnectorsResponse
    {

        /// <summary>
        /// HTTP Response Status Code
        /// </summary>
        [JsonProperty("status_code")]
        public long StatusCode { get; set; } = default!;

        /// <summary>
        /// HTTP Response Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; } = default!;

        [JsonProperty("data")]
        public List<Models.Components.Connector> Data { get; set; } = default!;

        /// <summary>
        /// Response metadata
        /// </summary>
        [JsonProperty("meta")]
        public Meta? Meta { get; set; }

        /// <summary>
        /// Links to navigate to previous or next pages through the API
        /// </summary>
        [JsonProperty("links")]
        public Links? Links { get; set; }
    }
}