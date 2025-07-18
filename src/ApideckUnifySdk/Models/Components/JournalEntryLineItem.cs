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
    
    public class JournalEntryLineItem
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// User defined description
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// Tax amount
        /// </summary>
        [JsonProperty("tax_amount")]
        public double? TaxAmount { get; set; } = null;

        /// <summary>
        /// Sub-total amount, normally before tax.
        /// </summary>
        [JsonProperty("sub_total")]
        public double? SubTotal { get; set; } = null;

        /// <summary>
        /// Debit entries are considered positive, and credit entries are considered negative.
        /// </summary>
        [JsonProperty("total_amount")]
        public double? TotalAmount { get; set; } = null;

        /// <summary>
        /// Debit entries are considered positive, and credit entries are considered negative.
        /// </summary>
        [JsonProperty("type")]
        public JournalEntryLineItemType Type { get; set; } = default!;

        [JsonProperty("tax_rate")]
        public LinkedTaxRate? TaxRate { get; set; }

        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("tracking_category")]
        public DeprecatedLinkedTrackingCategory? TrackingCategory { get; set; } = null;

        /// <summary>
        /// A list of linked tracking categories.
        /// </summary>
        [JsonProperty("tracking_categories")]
        public List<LinkedTrackingCategory?>? TrackingCategories { get; set; } = null;

        [JsonProperty("ledger_account", NullValueHandling = NullValueHandling.Include)]
        public LinkedLedgerAccount? LedgerAccount { get; set; }

        /// <summary>
        /// The customer this entity is linked to.
        /// </summary>
        [JsonProperty("customer")]
        public LinkedCustomer? Customer { get; set; } = null;

        /// <summary>
        /// The supplier this entity is linked to.
        /// </summary>
        [JsonProperty("supplier")]
        public LinkedSupplier? Supplier { get; set; } = null;

        /// <summary>
        /// The ID of the department
        /// </summary>
        [JsonProperty("department_id")]
        public string? DepartmentId { get; set; } = null;

        /// <summary>
        /// The ID of the location
        /// </summary>
        [JsonProperty("location_id")]
        public string? LocationId { get; set; } = null;

        /// <summary>
        /// Line number of the resource
        /// </summary>
        [JsonProperty("line_number")]
        public long? LineNumber { get; set; } = null;
    }
}