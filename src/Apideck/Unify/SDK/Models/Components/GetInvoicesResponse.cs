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
    
    /// <summary>
    /// Invoices
    /// </summary>
    public class GetInvoicesResponse
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

        /// <summary>
        /// Apideck ID of service provider
        /// </summary>
        [JsonProperty("service")]
        public string Service { get; set; } = default!;

        /// <summary>
        /// Unified API resource name
        /// </summary>
        [JsonProperty("resource")]
        public string Resource { get; set; } = default!;

        /// <summary>
        /// Operation performed
        /// </summary>
        [JsonProperty("operation")]
        public string Operation { get; set; } = default!;

        [JsonProperty("data")]
        public List<Invoice> Data { get; set; } = default!;

        /// <summary>
        /// Response metadata
        /// </summary>
        [JsonProperty("meta")]
        public Meta? Meta { get; set; }

        /// <summary>
        /// Links to navigate to previous or next pages through the API
        /// </summary>
        [JsonProperty("links")]
        public Links? Links { get; set; }
    }
}