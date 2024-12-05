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
    using System.Collections.Generic;
    
    /// <summary>
    /// Tracking categories
    /// </summary>
    public class GetTrackingCategoriesResponse
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
        public List<TrackingCategory> Data { get; set; } = default!;

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