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
    /// Credit Note created
    /// </summary>
    public class CreateCreditNoteResponse
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

        /// <summary>
        /// A object containing a unique identifier for the resource that was created, updated, or deleted.
        /// </summary>
        [JsonProperty("data")]
        public UnifiedId Data { get; set; } = default!;
    }
}