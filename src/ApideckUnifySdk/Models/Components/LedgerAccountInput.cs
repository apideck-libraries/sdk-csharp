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
    using NodaTime;
    using System;
    using System.Collections.Generic;
    
    public class LedgerAccountInput
    {

        /// <summary>
        /// The human readable display ID used when displaying the account
        /// </summary>
        [JsonProperty("display_id")]
        public string? DisplayId { get; set; }

        /// <summary>
        /// The nominal code of the ledger account.
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("nominal_code")]
        public string? NominalCode { get; set; } = null;

        /// <summary>
        /// The code assigned to the account.
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; } = null;

        /// <summary>
        /// The classification of account.
        /// </summary>
        [JsonProperty("classification")]
        public Classification? Classification { get; set; } = null;

        /// <summary>
        /// The type of account.
        /// </summary>
        [JsonProperty("type")]
        public LedgerAccountType? Type { get; set; }

        /// <summary>
        /// The sub type of account.
        /// </summary>
        [JsonProperty("sub_type")]
        public string? SubType { get; set; } = null;

        /// <summary>
        /// The name of the account.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// The fully qualified name of the account.
        /// </summary>
        [JsonProperty("fully_qualified_name")]
        public string? FullyQualifiedName { get; set; } = null;

        /// <summary>
        /// The description of the account.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// The opening balance of the account.
        /// </summary>
        [JsonProperty("opening_balance")]
        public double? OpeningBalance { get; set; } = null;

        /// <summary>
        /// The current balance of the account.
        /// </summary>
        [JsonProperty("current_balance")]
        public double? CurrentBalance { get; set; } = null;

        /// <summary>
        /// Indicates the associated currency for an amount of money. Values correspond to <a href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217</a>.
        /// </summary>
        [JsonProperty("currency")]
        public Currency? Currency { get; set; } = null;

        /// <summary>
        /// The tax type of the account.
        /// </summary>
        [JsonProperty("tax_type")]
        public string? TaxType { get; set; } = null;

        [JsonProperty("tax_rate")]
        public LinkedTaxRateInput? TaxRate { get; set; }

        [JsonProperty("level")]
        public double? Level { get; set; } = null;

        /// <summary>
        /// Whether the account is active or not.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; } = null;

        /// <summary>
        /// The status of the account.
        /// </summary>
        [JsonProperty("status")]
        public AccountStatus? Status { get; set; } = null;

        /// <summary>
        /// Whether the account is a header or not.
        /// </summary>
        [JsonProperty("header")]
        public bool? Header { get; set; } = null;

        [JsonProperty("bank_account")]
        public BankAccount? BankAccount { get; set; }

        [JsonProperty("parent_account")]
        public ParentAccount? ParentAccount { get; set; }

        /// <summary>
        /// Whether the account is a sub account or not.
        /// </summary>
        [JsonProperty("sub_account")]
        public bool? SubAccount { get; set; } = null;

        /// <summary>
        /// Reconciliation Date means the last calendar day of each Reconciliation Period.
        /// </summary>
        [JsonProperty("last_reconciliation_date")]
        public LocalDate? LastReconciliationDate { get; set; } = null;

        /// <summary>
        /// The subsidiaries the account belongs to.
        /// </summary>
        [JsonProperty("subsidiaries")]
        public List<LedgerAccountSubsidiaries>? Subsidiaries { get; set; }

        [JsonProperty("custom_fields")]
        public List<CustomField>? CustomFields { get; set; }

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