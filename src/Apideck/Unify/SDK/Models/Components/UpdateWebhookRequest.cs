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
    
    public class UpdateWebhookRequest
    {

        /// <summary>
        /// A description of the object.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// The status of the webhook.
        /// </summary>
        [JsonProperty("status")]
        public Status? Status { get; set; }

        /// <summary>
        /// The delivery url of the webhook endpoint.
        /// </summary>
        [JsonProperty("delivery_url")]
        public string? DeliveryUrl { get; set; }

        /// <summary>
        /// The list of subscribed events for this webhook. [`*`] indicates that all events are enabled.
        /// </summary>
        [JsonProperty("events")]
        public List<WebhookEventType>? Events { get; set; }
    }
}