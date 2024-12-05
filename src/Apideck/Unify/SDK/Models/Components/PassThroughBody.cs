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
    
    public class PassThroughBody
    {

        /// <summary>
        /// Identifier for the service to which this pass_through should be applied.
        /// </summary>
        [JsonProperty("service_id")]
        public string ServiceId { get; set; } = default!;

        /// <summary>
        /// Optional identifier for a workflow operation to which this pass_through should be applied. This is useful for Unify calls that are making more than one downstream request.
        /// </summary>
        [JsonProperty("operation_id")]
        public string? OperationId { get; set; }

        /// <summary>
        /// Simple object allowing any properties for direct extension.
        /// </summary>
        [JsonProperty("extend_object")]
        public Dictionary<string, object>? ExtendObject { get; set; }

        /// <summary>
        /// Array of objects for structured data modifications via paths.
        /// </summary>
        [JsonProperty("extend_paths")]
        public List<ExtendPaths>? ExtendPaths { get; set; }
    }
}