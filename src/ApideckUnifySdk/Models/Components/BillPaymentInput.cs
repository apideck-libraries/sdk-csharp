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
    
    public class BillPaymentInput
    {

        /// <summary>
        /// Indicates the associated currency for an amount of money. Values correspond to <a href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217</a>.
        /// </summary>
        [JsonProperty("currency")]
        public Currency? Currency { get; set; } = null;

        /// <summary>
        /// Currency Exchange Rate at the time entity was recorded/generated.
        /// </summary>
        [JsonProperty("currency_rate")]
        public double? CurrencyRate { get; set; } = null;

        /// <summary>
        /// The total amount of the transaction
        /// </summary>
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Include)]
        public double? TotalAmount { get; set; }

        /// <summary>
        /// Optional transaction reference message ie: Debit remittance detail.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; set; } = null;

        /// <summary>
        /// Payment method used for the transaction, such as cash, credit card, bank transfer, or check
        /// </summary>
        [JsonProperty("payment_method")]
        public string? PaymentMethod { get; set; } = null;

        /// <summary>
        /// Optional reference message returned by payment method on processing
        /// </summary>
        [JsonProperty("payment_method_reference")]
        public string? PaymentMethodReference { get; set; } = null;

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("payment_method_id")]
        public string? PaymentMethodId { get; set; } = null;

        [JsonProperty("account")]
        public LinkedLedgerAccountInput? Account { get; set; } = null;

        /// <summary>
        /// The date of the transaction - YYYY:MM::DDThh:mm:ss.sTZD
        /// </summary>
        [JsonProperty("transaction_date", NullValueHandling = NullValueHandling.Include)]
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// The supplier this entity is linked to.
        /// </summary>
        [JsonProperty("supplier")]
        public LinkedSupplierInput? Supplier { get; set; } = null;

        /// <summary>
        /// The company or subsidiary id the transaction belongs to
        /// </summary>
        [JsonProperty("company_id")]
        public string? CompanyId { get; set; } = null;

        /// <summary>
        /// Indicates if the transaction has been reconciled.
        /// </summary>
        [JsonProperty("reconciled")]
        public bool? Reconciled { get; set; } = null;

        /// <summary>
        /// Status of payment
        /// </summary>
        [JsonProperty("status")]
        public PaymentStatus? Status { get; set; }

        /// <summary>
        /// Type of payment
        /// </summary>
        [JsonProperty("type")]
        public BillPaymentType? Type { get; set; }

        [JsonProperty("allocations")]
        public List<BillPaymentAllocations>? Allocations { get; set; }

        /// <summary>
        /// Note associated with the transaction
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; set; } = null;

        /// <summary>
        /// Number associated with the transaction
        /// </summary>
        [JsonProperty("number")]
        public string? Number { get; set; } = null;

        /// <summary>
        /// A list of linked tracking categories.
        /// </summary>
        [JsonProperty("tracking_categories")]
        public List<LinkedTrackingCategory>? TrackingCategories { get; set; } = null;

        [JsonProperty("custom_fields")]
        public List<CustomField>? CustomFields { get; set; }

        /// <summary>
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        [JsonProperty("row_version")]
        public string? RowVersion { get; set; } = null;

        /// <summary>
        /// Id to be displayed.
        /// </summary>
        [JsonProperty("display_id")]
        public string? DisplayId { get; set; } = null;

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }
    }
}