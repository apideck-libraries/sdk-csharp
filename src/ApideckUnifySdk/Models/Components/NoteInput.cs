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
    
    public class NoteInput
    {

        /// <summary>
        /// The title of the note
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// The content of the note.
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; } = null;

        /// <summary>
        /// The user that owns the note.
        /// </summary>
        [JsonProperty("owner_id")]
        public string? OwnerId { get; set; } = null;

        /// <summary>
        /// The contact that is related to the note.
        /// </summary>
        [JsonProperty("contact_id")]
        public string? ContactId { get; set; } = null;

        /// <summary>
        /// The company that is related to the note.
        /// </summary>
        [JsonProperty("company_id")]
        public string? CompanyId { get; set; } = null;

        /// <summary>
        /// The opportunity that is related to the note.
        /// </summary>
        [JsonProperty("opportunity_id")]
        public string? OpportunityId { get; set; } = null;

        /// <summary>
        /// The lead that is related to the note.
        /// </summary>
        [JsonProperty("lead_id")]
        public string? LeadId { get; set; } = null;

        /// <summary>
        /// Whether the Note is active or not.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; } = null;

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }
    }
}