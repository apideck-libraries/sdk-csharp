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
    using Unify.Utils;
    
    /// <summary>
    /// Represents the tracking information associated with an ecommerce order.
    /// </summary>
    public class TrackingItem
    {

        /// <summary>
        /// The name or code of the carrier or shipping company that is handling the shipment.
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Include)]
        public string? Provider { get; set; }

        /// <summary>
        ///  The tracking number associated with the shipment, which can be used to track the progress of the delivery.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Include)]
        public string? Number { get; set; }

        /// <summary>
        /// The URL of the carrier&apos;s tracking page, which can be used to view detailed information about the shipment&apos;s progress.
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; } = null;

        /// <summary>
        /// The date and time when the object was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;
    }
}