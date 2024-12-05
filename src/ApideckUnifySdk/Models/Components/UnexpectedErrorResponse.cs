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
    /// Unexpected error
    /// </summary>
    public class UnexpectedErrorResponse
    {

        /// <summary>
        /// HTTP status code
        /// </summary>
        [JsonProperty("status_code")]
        public double? StatusCode { get; set; }

        /// <summary>
        /// Contains an explanation of the status_code as defined in HTTP/1.1 standard (RFC 7231)
        /// </summary>
        [JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The type of error returned
        /// </summary>
        [JsonProperty("type_name")]
        public string? TypeName { get; set; }

        /// <summary>
        /// A human-readable message providing more details about the error.
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Contains parameter or domain specific information related to the error and why it occurred.
        /// </summary>
        [JsonProperty("detail")]
        public Models.Components.Detail? Detail { get; set; }

        /// <summary>
        /// Link to documentation of error type
        /// </summary>
        [JsonProperty("ref")]
        public string? Ref { get; set; }
    }
}