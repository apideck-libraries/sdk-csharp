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
    using System;
    
    /// <summary>
    /// The supplier this entity is linked to.
    /// </summary>
    [Obsolete("This will be removed in a future release, please migrate away from it as soon as possible")]
    public class DeprecatedLinkedSupplierInput
    {

        /// <summary>
        /// The display name of the supplier.
        /// </summary>
        [JsonProperty("display_name")]
        public string? DisplayName { get; set; } = null;

        [JsonProperty("address")]
        public Address? Address { get; set; }
    }
}