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
    
    public class Supplier
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The third-party API ID of original entity
        /// </summary>
        [JsonProperty("downstream_id")]
        public string? DownstreamId { get; set; } = null;

        /// <summary>
        /// Display ID
        /// </summary>
        [JsonProperty("display_id")]
        public string? DisplayId { get; set; } = null;

        /// <summary>
        /// Display name
        /// </summary>
        [JsonProperty("display_name")]
        public string? DisplayName { get; set; } = null;

        /// <summary>
        /// The name of the company.
        /// </summary>
        [JsonProperty("company_name")]
        public string? CompanyName { get; set; } = null;

        /// <summary>
        /// The company or subsidiary id the transaction belongs to
        /// </summary>
        [JsonProperty("company_id")]
        public string? CompanyId { get; set; } = null;

        /// <summary>
        /// The job title of the person.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// The first name of the person.
        /// </summary>
        [JsonProperty("first_name")]
        public string? FirstName { get; set; } = null;

        /// <summary>
        /// Middle name of the person.
        /// </summary>
        [JsonProperty("middle_name")]
        public string? MiddleName { get; set; } = null;

        /// <summary>
        /// The last name of the person.
        /// </summary>
        [JsonProperty("last_name")]
        public string? LastName { get; set; } = null;

        [JsonProperty("suffix")]
        public string? Suffix { get; set; } = null;

        /// <summary>
        /// Is this an individual or business supplier
        /// </summary>
        [JsonProperty("individual")]
        public bool? Individual { get; set; } = null;

        [JsonProperty("addresses")]
        public List<Address>? Addresses { get; set; }

        [JsonProperty("phone_numbers")]
        public List<PhoneNumber>? PhoneNumbers { get; set; }

        [JsonProperty("emails")]
        public List<Email>? Emails { get; set; }

        [JsonProperty("websites")]
        public List<Website>? Websites { get; set; }

        [JsonProperty("bank_accounts")]
        public List<BankAccount>? BankAccounts { get; set; }

        /// <summary>
        /// Some notes about this supplier
        /// </summary>
        [JsonProperty("notes")]
        public string? Notes { get; set; } = null;

        [JsonProperty("tax_rate")]
        public LinkedTaxRate? TaxRate { get; set; }

        [JsonProperty("tax_number")]
        public string? TaxNumber { get; set; } = null;

        /// <summary>
        /// Indicates the associated currency for an amount of money. Values correspond to <a href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217</a>.
        /// </summary>
        [JsonProperty("currency")]
        public Currency? Currency { get; set; } = null;

        [JsonProperty("account")]
        public LinkedLedgerAccount? Account { get; set; } = null;

        /// <summary>
        /// Supplier status
        /// </summary>
        [JsonProperty("status")]
        public SupplierStatus? Status { get; set; } = null;

        /// <summary>
        /// Payment method used for the transaction, such as cash, credit card, bank transfer, or check
        /// </summary>
        [JsonProperty("payment_method")]
        public string? PaymentMethod { get; set; } = null;

        /// <summary>
        /// The channel through which the transaction is processed.
        /// </summary>
        [JsonProperty("channel")]
        public string? Channel { get; set; } = null;

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        [JsonProperty("custom_mappings")]
        public Models.Components.CustomMappings? CustomMappings { get; set; } = null;

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
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        [JsonProperty("row_version")]
        public string? RowVersion { get; set; } = null;

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }

        /// <summary>
        /// The subsidiary the supplier belongs to.
        /// </summary>
        [JsonProperty("subsidiary_id")]
        public string? SubsidiaryId { get; set; }
    }
}