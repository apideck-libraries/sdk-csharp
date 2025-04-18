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
    
    public class LinkedConnectorResource
    {

        /// <summary>
        /// ID of the resource, typically a lowercased version of name.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the resource (plural)
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Status of the resource. Resources with status live or beta are callable.
        /// </summary>
        [JsonProperty("status")]
        public ResourceStatus? Status { get; set; }

        /// <summary>
        /// ID of the resource in the Connector&apos;s API (downstream)
        /// </summary>
        [JsonProperty("downstream_id")]
        public string? DownstreamId { get; set; }

        /// <summary>
        /// Name of the resource in the Connector&apos;s API (downstream)
        /// </summary>
        [JsonProperty("downstream_name")]
        public string? DownstreamName { get; set; }
    }
}