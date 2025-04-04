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
    
    public class BillLineItemInput
    {

        /// <summary>
        /// Row ID
        /// </summary>
        [JsonProperty("row_id")]
        public string? RowId { get; set; }

        /// <summary>
        /// User defined item code
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; } = null;

        /// <summary>
        /// Line number in the invoice
        /// </summary>
        [JsonProperty("line_number")]
        public long? LineNumber { get; set; } = null;

        /// <summary>
        /// User defined description
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// Bill Line Item type
        /// </summary>
        [JsonProperty("type")]
        public BillLineItemType? Type { get; set; } = null;

        /// <summary>
        /// Tax amount
        /// </summary>
        [JsonProperty("tax_amount")]
        public double? TaxAmount { get; set; } = null;

        /// <summary>
        /// Total amount of the line item
        /// </summary>
        [JsonProperty("total_amount")]
        public double? TotalAmount { get; set; } = null;

        [JsonProperty("quantity")]
        public double? Quantity { get; set; } = null;

        [JsonProperty("unit_price")]
        public double? UnitPrice { get; set; } = null;

        /// <summary>
        /// Description of the unit type the item is sold as, ie: kg, hour.
        /// </summary>
        [JsonProperty("unit_of_measure")]
        public string? UnitOfMeasure { get; set; } = null;

        /// <summary>
        /// Discount percentage applied to the line item when supported downstream.
        /// </summary>
        [JsonProperty("discount_percentage")]
        public double? DiscountPercentage { get; set; } = null;

        /// <summary>
        /// Discount amount applied to the line item when supported downstream.
        /// </summary>
        [JsonProperty("discount_amount")]
        public double? DiscountAmount { get; set; } = null;

        /// <summary>
        /// The ID of the location
        /// </summary>
        [JsonProperty("location_id")]
        public string? LocationId { get; set; } = null;

        /// <summary>
        /// The ID of the department
        /// </summary>
        [JsonProperty("department_id")]
        public string? DepartmentId { get; set; } = null;

        [JsonProperty("item")]
        public LinkedInvoiceItem? Item { get; set; }

        [JsonProperty("tax_rate")]
        public LinkedTaxRateInput? TaxRate { get; set; }

        [JsonProperty("ledger_account")]
        public LinkedLedgerAccountInput? LedgerAccount { get; set; } = null;

        /// <summary>
        /// A list of linked tracking categories.
        /// </summary>
        [JsonProperty("tracking_categories")]
        public List<LinkedTrackingCategory>? TrackingCategories { get; set; } = null;

        /// <summary>
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        [JsonProperty("row_version")]
        public string? RowVersion { get; set; } = null;
    }
}