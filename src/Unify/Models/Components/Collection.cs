//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Unify.Models.Components
{
    using Newtonsoft.Json;
    using System;
    using Unify.Models.Components;
    using Unify.Utils;
    
    public class Collection
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The collections&apos;s parent ID
        /// </summary>
        [JsonProperty("parent_id")]
        public string? ParentId { get; set; } = null;

        /// <summary>
        /// The collections&apos;s type
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; } = null;

        /// <summary>
        /// Name of the collection
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// Description of the collection
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        [JsonProperty("custom_mappings")]
        public Models.Components.CustomMappings? CustomMappings { get; set; } = null;

        /// <summary>
        /// The date and time when the object was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;
    }
}