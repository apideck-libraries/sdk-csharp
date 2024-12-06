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
    /// How webhooks are supported for the connector. Sometimes the connector natively supports webhooks, other times Apideck virtualizes them based on polling.
    /// </summary>
    public class WebhookSupport
    {

        /// <summary>
        /// Mode of the webhook support.
        /// </summary>
        [JsonProperty("mode")]
        public Mode? Mode { get; set; }

        /// <summary>
        /// Received events are scoped to connection or across integration.
        /// </summary>
        [JsonProperty("subscription_level")]
        public SubscriptionLevel? SubscriptionLevel { get; set; }

        /// <summary>
        /// How the subscription is managed in the downstream.
        /// </summary>
        [JsonProperty("managed_via")]
        public ManagedVia? ManagedVia { get; set; }

        /// <summary>
        /// Virtual webhook config for the connector.
        /// </summary>
        [JsonProperty("virtual_webhooks")]
        public VirtualWebhooks? VirtualWebhooks { get; set; }
    }
}