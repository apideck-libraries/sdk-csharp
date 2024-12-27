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
    using System.Collections.Generic;
    
    public class Webhook
    {

        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// A description of the object.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// Name of Apideck Unified API
        /// </summary>
        [JsonProperty("unified_api")]
        public UnifiedApiId UnifiedApi { get; set; } = default!;

        /// <summary>
        /// The status of the webhook.
        /// </summary>
        [JsonProperty("status")]
        public Status Status { get; set; } = default!;

        /// <summary>
        /// Indicates if the webhook has has been disabled as it reached its retry limit or if account is over the usage allocated by it&apos;s plan.
        /// </summary>
        [JsonProperty("disabled_reason")]
        public DisabledReason? DisabledReason { get; set; }

        /// <summary>
        /// The delivery url of the webhook endpoint.
        /// </summary>
        [JsonProperty("delivery_url")]
        public string DeliveryUrl { get; set; } = default!;

        /// <summary>
        /// The Unify Base URL events from connectors will be sent to after service id is appended.
        /// </summary>
        [JsonProperty("execute_base_url")]
        public string ExecuteBaseUrl { get; set; } = default!;

        /// <summary>
        /// The list of subscribed events for this webhook. [`*`] indicates that all events are enabled.
        /// </summary>
        [JsonProperty("events")]
        public List<WebhookEventType> Events { get; set; } = default!;

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