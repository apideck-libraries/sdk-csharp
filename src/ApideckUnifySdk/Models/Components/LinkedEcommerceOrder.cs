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
    
    /// <summary>
    /// The order this entity is linked to.
    /// </summary>
    public class LinkedEcommerceOrder
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The total amount of the order.
        /// </summary>
        [JsonProperty("total")]
        public string? Total { get; set; } = null;

        /// <summary>
        /// Current status of the order.
        /// </summary>
        [JsonProperty("status")]
        public EcommerceOrderStatus? Status { get; set; } = null;
    }
}