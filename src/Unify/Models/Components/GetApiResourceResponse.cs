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
    using Unify.Models.Components;
    using Unify.Utils;
    
    /// <summary>
    /// ApiResources
    /// </summary>
    public class GetApiResourceResponse
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
        public ApiResource Data { get; set; } = default!;

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