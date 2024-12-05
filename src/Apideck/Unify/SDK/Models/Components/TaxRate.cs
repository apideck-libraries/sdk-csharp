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
    using System;
    
    public class TaxRate
    {

        /// <summary>
        /// ID assigned to identify this tax rate.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// Name assigned to identify this tax rate.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Tax code assigned to identify this tax rate.
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; } = null;

        /// <summary>
        /// Description of tax rate
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// Effective tax rate
        /// </summary>
        [JsonProperty("effective_tax_rate")]
        public double? EffectiveTaxRate { get; set; } = null;

        /// <summary>
        /// Not compounded sum of the components of a tax rate
        /// </summary>
        [JsonProperty("total_tax_rate")]
        public double? TotalTaxRate { get; set; } = null;

        /// <summary>
        /// Unique identifier for the account for tax collected.
        /// </summary>
        [JsonProperty("tax_payable_account_id")]
        public string? TaxPayableAccountId { get; set; } = null;

        /// <summary>
        /// Unique identifier for the account for tax remitted.
        /// </summary>
        [JsonProperty("tax_remitted_account_id")]
        public string? TaxRemittedAccountId { get; set; } = null;

        [JsonProperty("components")]
        public List<Components>? Components { get; set; } = null;

        /// <summary>
        /// Tax type used to indicate the source of tax collected or paid
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; } = null;

        /// <summary>
        /// Report Tax type to aggregate tax collected or paid for reporting purposes
        /// </summary>
        [JsonProperty("report_tax_type")]
        public string? ReportTaxType { get; set; } = null;

        /// <summary>
        /// ID of the original tax rate from which the new tax rate is derived. Helps to understand the relationship between corresponding tax rate entities.
        /// </summary>
        [JsonProperty("original_tax_rate_id")]
        public string? OriginalTaxRateId { get; set; } = null;

        /// <summary>
        /// Tax rate status
        /// </summary>
        [JsonProperty("status")]
        public TaxRateStatus? Status { get; set; } = null;

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        [JsonProperty("custom_mappings")]
        public Models.Components.CustomMappings? CustomMappings { get; set; } = null;

        /// <summary>
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        [JsonProperty("row_version")]
        public string? RowVersion { get; set; } = null;

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