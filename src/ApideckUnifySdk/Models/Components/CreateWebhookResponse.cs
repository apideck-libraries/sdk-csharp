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
    /// Webhooks
    /// </summary>
    public class CreateWebhookResponse
    {

        /// <summary>
        /// HTTP Response Status Code
        /// </summary>
        [JsonProperty("status_code")]
        public long StatusCode { get; set; } = default!;

        /// <summary>
        /// HTTP Response Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; } = default!;

        [JsonProperty("data")]
        public Models.Components.Webhook Data { get; set; } = default!;
    }
}