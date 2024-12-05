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
    
    public class ExpenseLineItemInput
    {

        /// <summary>
        /// A list of linked tracking categories.
        /// </summary>
        [JsonProperty("tracking_categories")]
        public List<LinkedTrackingCategory>? TrackingCategories { get; set; } = null;

        /// <summary>
        /// The unique identifier for the ledger account.
        /// </summary>
        [JsonProperty("account_id")]
        public string? AccountId { get; set; }

        /// <summary>
        /// The ID of the customer this expense item is linked to.
        /// </summary>
        [JsonProperty("customer_id")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// The ID of the department this expense item is linked to.
        /// </summary>
        [JsonProperty("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// The ID of the location this expense item is linked to.
        /// </summary>
        [JsonProperty("location_id")]
        public string? LocationId { get; set; }

        [JsonProperty("tax_rate")]
        public LinkedTaxRateInput? TaxRate { get; set; }

        /// <summary>
        /// The expense line item description
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// The total amount of the expense line item.
        /// </summary>
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Include)]
        public double? TotalAmount { get; set; }

        /// <summary>
        /// Boolean that indicates if the line item is billable or not.
        /// </summary>
        [JsonProperty("billable")]
        public bool? Billable { get; set; }
    }
}