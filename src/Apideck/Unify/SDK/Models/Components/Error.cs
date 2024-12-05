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
    using Apideck.Unify.SDK.Utils;
    using Newtonsoft.Json;
    
    /// <summary>
    /// The error returned if your message status is failed or undelivered.
    /// </summary>
    public class Error
    {

        /// <summary>
        /// The error_code provides more information about the failure. If the message was successful, this value is null
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}