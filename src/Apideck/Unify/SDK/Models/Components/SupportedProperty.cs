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
    
    public class SupportedProperty
    {

        /// <summary>
        /// Name of the property in our Unified API.
        /// </summary>
        [JsonProperty("unified_property")]
        public string? UnifiedProperty { get; set; }

        /// <summary>
        /// List of child properties of the unified property.
        /// </summary>
        [JsonProperty("child_properties")]
        public List<SupportedProperty>? ChildProperties { get; set; }
    }
}