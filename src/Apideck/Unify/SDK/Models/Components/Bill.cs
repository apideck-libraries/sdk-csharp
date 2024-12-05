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
    using NodaTime;
    using System.Collections.Generic;
    using System;
    
    public class Bill
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The third-party API ID of original entity
        /// </summary>
        [JsonProperty("downstream_id")]
        public string? DownstreamId { get; set; } = null;

        /// <summary>
        /// Reference to supplier bill number
        /// </summary>
        [JsonProperty("bill_number")]
        public string? BillNumber { get; set; } = null;

        /// <summary>
        /// The supplier this entity is linked to.
        /// </summary>
        [JsonProperty("supplier")]
        public LinkedSupplier? Supplier { get; set; } = null;

        /// <summary>
        /// The company or subsidiary id the transaction belongs to
        /// </summary>
        [JsonProperty("company_id")]
        public string? CompanyId { get; set; } = null;

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
        /// Amounts are including tax
        /// </summary>
        [JsonProperty("tax_inclusive")]
        public bool? TaxInclusive { get; set; } = null;

        /// <summary>
        /// Date bill was issued - YYYY-MM-DD.
        /// </summary>
        [JsonProperty("bill_date")]
        public LocalDate? BillDate { get; set; }

        /// <summary>
        /// The due date is the date on which a payment is scheduled to be received - YYYY-MM-DD.
        /// </summary>
        [JsonProperty("due_date")]
        public LocalDate? DueDate { get; set; }

        /// <summary>
        /// The paid date is the date on which a payment was sent to the supplier - YYYY-MM-DD.
        /// </summary>
        [JsonProperty("paid_date")]
        public LocalDate? PaidDate { get; set; } = null;

        /// <summary>
        /// A PO Number uniquely identifies a purchase order and is generally defined by the buyer. The buyer will match the PO number in the invoice to the Purchase Order.
        /// </summary>
        [JsonProperty("po_number")]
        public string? PoNumber { get; set; } = null;

        /// <summary>
        /// Optional bill reference.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; set; } = null;

        [JsonProperty("line_items")]
        public List<BillLineItem>? LineItems { get; set; }

        /// <summary>
        /// Terms of payment.
        /// </summary>
        [JsonProperty("terms")]
        public string? Terms { get; set; } = null;

        /// <summary>
        /// Balance of bill due.
        /// </summary>
        [JsonProperty("balance")]
        public double? Balance { get; set; } = null;

        /// <summary>
        /// Amount of deposit made to this bill.
        /// </summary>
        [JsonProperty("deposit")]
        public double? Deposit { get; set; } = null;

        /// <summary>
        /// Sub-total amount, normally before tax.
        /// </summary>
        [JsonProperty("sub_total")]
        public double? SubTotal { get; set; } = null;

        /// <summary>
        /// Total tax amount applied to this bill.
        /// </summary>
        [JsonProperty("total_tax")]
        public double? TotalTax { get; set; } = null;

        /// <summary>
        /// Total amount of bill, including tax.
        /// </summary>
        [JsonProperty("total")]
        public double? Total { get; set; } = null;

        /// <summary>
        /// Applicable tax id/code override if tax is not supplied on a line item basis.
        /// </summary>
        [JsonProperty("tax_code")]
        public string? TaxCode { get; set; } = null;

        [JsonProperty("notes")]
        public string? Notes { get; set; } = null;

        /// <summary>
        /// Invoice status
        /// </summary>
        [JsonProperty("status")]
        public BillStatus? Status { get; set; } = null;

        [JsonProperty("ledger_account")]
        public LinkedLedgerAccount? LedgerAccount { get; set; } = null;

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
        /// language code according to ISO 639-1. For the United States - EN
        /// </summary>
        [JsonProperty("language")]
        public string? Language { get; set; } = null;

        /// <summary>
        /// Indicates if accounting by row is used (true) or not (false). Accounting by row means that a separate ledger transaction is created for each row.
        /// </summary>
        [JsonProperty("accounting_by_row")]
        public bool? AccountingByRow { get; set; } = null;

        [JsonProperty("bank_account")]
        public BankAccount? BankAccount { get; set; }

        /// <summary>
        /// Discount percentage applied to this transaction.
        /// </summary>
        [JsonProperty("discount_percentage")]
        public double? DiscountPercentage { get; set; } = null;

        /// <summary>
        /// A list of linked tracking categories.
        /// </summary>
        [JsonProperty("tracking_categories")]
        public List<LinkedTrackingCategory>? TrackingCategories { get; set; } = null;

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
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        [JsonProperty("custom_mappings")]
        public Models.Components.CustomMappings? CustomMappings { get; set; } = null;

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }

        /// <summary>
        /// Accounting period
        /// </summary>
        [JsonProperty("accounting_period")]
        public string? AccountingPeriod { get; set; } = null;
    }
}