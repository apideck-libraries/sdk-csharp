//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Unify.Models.Components
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    using Unify.Models.Components;
    using Unify.Utils;
    
    public class JournalEntry
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Journal entry title
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// Currency Exchange Rate at the time entity was recorded/generated.
        /// </summary>
        [JsonProperty("currency_rate")]
        public double? CurrencyRate { get; set; } = null;

        /// <summary>
        /// Indicates the associated currency for an amount of money. Values correspond to <a href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217</a>.
        /// </summary>
        [JsonProperty("currency")]
        public Currency? Currency { get; set; } = null;

        /// <summary>
        /// The company or subsidiary id the transaction belongs to
        /// </summary>
        [JsonProperty("company_id")]
        public string? CompanyId { get; set; } = null;

        /// <summary>
        /// Requires a minimum of 2 line items that sum to 0
        /// </summary>
        [JsonProperty("line_items")]
        public List<JournalEntryLineItem>? LineItems { get; set; }

        /// <summary>
        /// Reference for the journal entry.
        /// </summary>
        [JsonProperty("memo")]
        public string? Memo { get; set; } = null;

        /// <summary>
        /// This is the date on which the journal entry was added. This can be different from the creation date and can also be backdated.
        /// </summary>
        [JsonProperty("posted_at")]
        public DateTime? PostedAt { get; set; }

        /// <summary>
        /// Journal symbol of the entry. For example IND for indirect costs
        /// </summary>
        [JsonProperty("journal_symbol")]
        public string? JournalSymbol { get; set; } = null;

        /// <summary>
        /// The specific category of tax associated with a transaction like sales or purchase
        /// </summary>
        [JsonProperty("tax_type")]
        public string? TaxType { get; set; } = null;

        /// <summary>
        /// Applicable tax id/code override if tax is not supplied on a line item basis.
        /// </summary>
        [JsonProperty("tax_code")]
        public string? TaxCode { get; set; } = null;

        /// <summary>
        /// Journal entry number.
        /// </summary>
        [JsonProperty("number")]
        public string? Number { get; set; } = null;

        /// <summary>
        /// A list of linked tracking categories.
        /// </summary>
        [JsonProperty("tracking_categories")]
        public List<LinkedTrackingCategory>? TrackingCategories { get; set; } = null;

        /// <summary>
        /// Accounting period
        /// </summary>
        [JsonProperty("accounting_period")]
        public string? AccountingPeriod { get; set; } = null;

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
    }
}