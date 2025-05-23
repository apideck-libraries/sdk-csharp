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
    using NodaTime;
    using System;
    using System.Collections.Generic;
    
    public class Applicant
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of an applicant.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The first name of the person.
        /// </summary>
        [JsonProperty("first_name")]
        public string? FirstName { get; set; } = null;

        /// <summary>
        /// The last name of the person.
        /// </summary>
        [JsonProperty("last_name")]
        public string? LastName { get; set; } = null;

        /// <summary>
        /// Middle name of the person.
        /// </summary>
        [JsonProperty("middle_name")]
        public string? MiddleName { get; set; } = null;

        /// <summary>
        /// The initials of the person, usually derived from their first, middle, and last names.
        /// </summary>
        [JsonProperty("initials")]
        public string? Initials { get; set; } = null;

        /// <summary>
        /// The date of birth of the person.
        /// </summary>
        [JsonProperty("birthday")]
        public LocalDate? Birthday { get; set; } = null;

        [JsonProperty("cover_letter")]
        public string? CoverLetter { get; set; }

        [JsonProperty("job_url")]
        public string? JobUrl { get; set; } = null;

        /// <summary>
        /// The URL of the photo of a person.
        /// </summary>
        [JsonProperty("photo_url")]
        public string? PhotoUrl { get; set; } = null;

        /// <summary>
        /// Typically a list of previous companies where the contact has worked or schools that the contact has attended
        /// </summary>
        [JsonProperty("headline")]
        public string? Headline { get; set; }

        /// <summary>
        /// The job title of the person.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; } = null;

        [JsonProperty("emails")]
        public List<Email>? Emails { get; set; }

        [JsonProperty("custom_fields")]
        public List<CustomField>? CustomFields { get; set; }

        [JsonProperty("phone_numbers")]
        public List<PhoneNumber>? PhoneNumbers { get; set; }

        [JsonProperty("addresses")]
        public List<Address>? Addresses { get; set; }

        [JsonProperty("websites")]
        public List<Websites>? Websites { get; set; }

        [JsonProperty("social_links")]
        public List<SocialLinks>? SocialLinks { get; set; }

        [JsonProperty("stage_id")]
        public string? StageId { get; set; }

        [JsonProperty("recruiter_id")]
        public string? RecruiterId { get; set; }

        [JsonProperty("coordinator_id")]
        public string? CoordinatorId { get; set; }

        [JsonProperty("application_ids")]
        public List<string>? ApplicationIds { get; set; } = null;

        [JsonProperty("applications")]
        public List<string>? Applications { get; set; } = null;

        [JsonProperty("followers")]
        public List<string>? Followers { get; set; } = null;

        [JsonProperty("sources")]
        public List<string>? Sources { get; set; } = null;

        [JsonProperty("source_id")]
        public string? SourceId { get; set; }

        [JsonProperty("confidential")]
        public bool? Confidential { get; set; }

        [JsonProperty("anonymized")]
        public bool? Anonymized { get; set; }

        [JsonProperty("tags")]
        public List<string>? Tags { get; set; } = null;

        [JsonProperty("archived")]
        public bool? Archived { get; set; } = null;

        [JsonProperty("last_interaction_at")]
        public DateTime? LastInteractionAt { get; set; } = null;

        [JsonProperty("owner_id")]
        public string? OwnerId { get; set; } = null;

        [JsonProperty("sourced_by")]
        public string? SourcedBy { get; set; } = null;

        [JsonProperty("cv_url")]
        public string? CvUrl { get; set; }

        [JsonProperty("record_url")]
        public string? RecordUrl { get; set; } = null;

        [JsonProperty("rejected_at")]
        public DateTime? RejectedAt { get; set; } = null;

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        [JsonProperty("custom_mappings")]
        public Dictionary<string, object>? CustomMappings { get; set; } = null;

        /// <summary>
        /// Flag to indicate if the object is deleted.
        /// </summary>
        [JsonProperty("deleted")]
        public bool? Deleted { get; set; } = null;

        /// <summary>
        /// The user who deleted the object.
        /// </summary>
        [JsonProperty("deleted_by")]
        public string? DeletedBy { get; set; } = null;

        /// <summary>
        /// The time at which the object was deleted.
        /// </summary>
        [JsonProperty("deleted_at")]
        public DateTime? DeletedAt { get; set; } = null;

        /// <summary>
        /// The user who last updated the object.
        /// </summary>
        [JsonProperty("updated_by")]
        public string? UpdatedBy { get; set; } = null;

        /// <summary>
        /// The user who created the object.
        /// </summary>
        [JsonProperty("created_by")]
        public string? CreatedBy { get; set; } = null;

        /// <summary>
        /// The date and time when the object was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }
    }
}