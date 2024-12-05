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
    using System;
    
    public class HrisCompany
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("legal_name", NullValueHandling = NullValueHandling.Include)]
        public string? LegalName { get; set; }

        [JsonProperty("display_name")]
        public string? DisplayName { get; set; } = null;

        [JsonProperty("subdomain")]
        public string? Subdomain { get; set; } = null;

        [JsonProperty("status")]
        public HrisCompanyStatus? Status { get; set; }

        /// <summary>
        /// An Company Number, Company ID or Company Code, is a unique number that has been assigned to each company.
        /// </summary>
        [JsonProperty("company_number")]
        public string? CompanyNumber { get; set; } = null;

        /// <summary>
        /// Indicates the associated currency for an amount of money. Values correspond to <a href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217</a>.
        /// </summary>
        [JsonProperty("currency")]
        public Currency? Currency { get; set; } = null;

        [JsonProperty("addresses")]
        public List<Address>? Addresses { get; set; }

        [JsonProperty("phone_numbers")]
        public List<PhoneNumber>? PhoneNumbers { get; set; }

        [JsonProperty("emails")]
        public List<Email>? Emails { get; set; }

        [JsonProperty("websites")]
        public List<Website>? Websites { get; set; }

        [JsonProperty("debtor_id")]
        public string? DebtorId { get; set; } = null;

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        [JsonProperty("custom_mappings")]
        public Models.Components.CustomMappings? CustomMappings { get; set; } = null;

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

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