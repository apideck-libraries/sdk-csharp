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
    using System;
    using System.Collections.Generic;
    
    public class ContactInput
    {

        /// <summary>
        /// Full name of the contact.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Include)]
        public string? Name { get; set; }

        /// <summary>
        /// The owner of the contact.
        /// </summary>
        [JsonProperty("owner_id")]
        public string? OwnerId { get; set; } = null;

        /// <summary>
        /// The type of the contact.
        /// </summary>
        [JsonProperty("type")]
        public Models.Components.Type? Type { get; set; } = null;

        /// <summary>
        /// The company the contact is associated with.
        /// </summary>
        [JsonProperty("company_id")]
        public string? CompanyId { get; set; } = null;

        /// <summary>
        /// The name of the company the contact is associated with.
        /// </summary>
        [JsonProperty("company_name")]
        public string? CompanyName { get; set; } = null;

        /// <summary>
        /// The lead the contact is associated with.
        /// </summary>
        [JsonProperty("lead_id")]
        public string? LeadId { get; set; } = null;

        /// <summary>
        /// The first name of the contact.
        /// </summary>
        [JsonProperty("first_name")]
        public string? FirstName { get; set; } = null;

        /// <summary>
        /// The middle name of the contact.
        /// </summary>
        [JsonProperty("middle_name")]
        public string? MiddleName { get; set; } = null;

        /// <summary>
        /// The last name of the contact.
        /// </summary>
        [JsonProperty("last_name")]
        public string? LastName { get; set; } = null;

        /// <summary>
        /// The prefix of the contact.
        /// </summary>
        [JsonProperty("prefix")]
        public string? Prefix { get; set; } = null;

        /// <summary>
        /// The suffix of the contact.
        /// </summary>
        [JsonProperty("suffix")]
        public string? Suffix { get; set; } = null;

        /// <summary>
        /// The job title of the contact.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// The department of the contact.
        /// </summary>
        [JsonProperty("department")]
        public string? Department { get; set; } = null;

        /// <summary>
        /// language code according to ISO 639-1. For the United States - EN
        /// </summary>
        [JsonProperty("language")]
        public string? Language { get; set; } = null;

        /// <summary>
        /// The gender of the contact.
        /// </summary>
        [JsonProperty("gender")]
        public ContactGender? Gender { get; set; } = null;

        /// <summary>
        /// The birthday of the contact.
        /// </summary>
        [JsonProperty("birthday")]
        public string? Birthday { get; set; } = null;

        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("image")]
        public string? Image { get; set; } = null;

        /// <summary>
        /// The URL of the photo of a person.
        /// </summary>
        [JsonProperty("photo_url")]
        public string? PhotoUrl { get; set; } = null;

        /// <summary>
        /// The lead source of the contact.
        /// </summary>
        [JsonProperty("lead_source")]
        public string? LeadSource { get; set; } = null;

        /// <summary>
        /// The fax number of the contact.
        /// </summary>
        [JsonProperty("fax")]
        public string? Fax { get; set; } = null;

        /// <summary>
        /// The description of the contact.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// The current balance of the contact.
        /// </summary>
        [JsonProperty("current_balance")]
        public double? CurrentBalance { get; set; } = null;

        /// <summary>
        /// The status of the contact.
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; } = null;

        /// <summary>
        /// The active status of the contact.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; } = null;

        [JsonProperty("websites")]
        public List<Website>? Websites { get; set; }

        [JsonProperty("addresses")]
        public List<Address>? Addresses { get; set; }

        [JsonProperty("social_links")]
        public List<SocialLink>? SocialLinks { get; set; }

        [JsonProperty("phone_numbers")]
        public List<PhoneNumber>? PhoneNumbers { get; set; }

        [JsonProperty("emails")]
        public List<Email>? Emails { get; set; }

        [JsonProperty("email_domain")]
        public string? EmailDomain { get; set; } = null;

        [JsonProperty("custom_fields")]
        public List<CustomField>? CustomFields { get; set; }

        [JsonProperty("tags")]
        public List<string>? Tags { get; set; } = null;

        /// <summary>
        /// The opportunity ids of the contact.
        /// </summary>
        [JsonProperty("opportunity_ids")]
        public List<string>? OpportunityIds { get; set; }

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }
    }
}