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
    
    public class Lead
    {

        /// <summary>
        /// Unique identifier for the contact.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Full name of the lead.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The name of the company the lead is associated with.
        /// </summary>
        [JsonProperty("company_name", NullValueHandling = NullValueHandling.Include)]
        public string? CompanyName { get; set; }

        /// <summary>
        /// The owner of the lead.
        /// </summary>
        [JsonProperty("owner_id")]
        public string? OwnerId { get; set; } = null;

        /// <summary>
        /// The name of the owner of the lead.
        /// </summary>
        [JsonProperty("owner_name")]
        public string? OwnerName { get; set; } = null;

        /// <summary>
        /// The company the lead is associated with.
        /// </summary>
        [JsonProperty("company_id")]
        public string? CompanyId { get; set; } = null;

        /// <summary>
        /// The identifier of the lead.
        /// </summary>
        [JsonProperty("lead_id")]
        public string? LeadId { get; set; } = null;

        /// <summary>
        /// The source of the lead.
        /// </summary>
        [JsonProperty("lead_source")]
        public string? LeadSource { get; set; } = null;

        /// <summary>
        /// The first name of the lead.
        /// </summary>
        [JsonProperty("first_name")]
        public string? FirstName { get; set; } = null;

        /// <summary>
        /// The last name of the lead.
        /// </summary>
        [JsonProperty("last_name")]
        public string? LastName { get; set; } = null;

        /// <summary>
        /// The description of the lead.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// The prefix of the lead.
        /// </summary>
        [JsonProperty("prefix")]
        public string? Prefix { get; set; } = null;

        /// <summary>
        /// The job title of the lead.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// language code according to ISO 639-1. For the United States - EN
        /// </summary>
        [JsonProperty("language")]
        public string? Language { get; set; } = null;

        [JsonProperty("status")]
        public string? Status { get; set; } = null;

        /// <summary>
        /// The monetary amount of the lead.
        /// </summary>
        [JsonProperty("monetary_amount")]
        public double? MonetaryAmount { get; set; } = null;

        /// <summary>
        /// Indicates the associated currency for an amount of money. Values correspond to <a href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217</a>.
        /// </summary>
        [JsonProperty("currency")]
        public Currency? Currency { get; set; } = null;

        /// <summary>
        /// The fax number of the lead.
        /// </summary>
        [JsonProperty("fax")]
        public string? Fax { get; set; } = null;

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

        [JsonProperty("custom_fields")]
        public List<CustomField>? CustomFields { get; set; }

        [JsonProperty("tags")]
        public List<string>? Tags { get; set; } = null;

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        [JsonProperty("custom_mappings")]
        public Models.Components.CustomMappings? CustomMappings { get; set; } = null;

        /// <summary>
        /// Date updated in ISO 8601 format
        /// </summary>
        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; } = null;

        /// <summary>
        /// Date created in ISO 8601 format
        /// </summary>
        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; } = null;

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }
    }
}