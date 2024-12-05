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
    
    public class ApplicationInput
    {

        [JsonProperty("applicant_id", NullValueHandling = NullValueHandling.Include)]
        public string? ApplicantId { get; set; }

        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Include)]
        public string? JobId { get; set; }

        [JsonProperty("status")]
        public ApplicationStatus? Status { get; set; } = null;

        [JsonProperty("stage")]
        public Stage? Stage { get; set; }

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }
    }
}