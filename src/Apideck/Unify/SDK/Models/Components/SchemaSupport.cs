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
    
    /// <summary>
    /// When a connector has schema_support, a call can be made to retrieve a json schema that describes a downstream resource.
    /// </summary>
    public class SchemaSupport
    {

        /// <summary>
        /// Can a resource schema be retrieved for this connector?
        /// </summary>
        [JsonProperty("supported")]
        public bool? Supported { get; set; }
    }
}