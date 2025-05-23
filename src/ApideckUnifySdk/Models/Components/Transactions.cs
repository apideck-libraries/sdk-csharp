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
    
    public class Transactions
    {

        /// <summary>
        /// The date of the transaction - YYYY:MM::DDThh:mm:ss.sTZD
        /// </summary>
        [JsonProperty("posted_date")]
        public DateTime PostedDate { get; set; } = default!;

        /// <summary>
        /// A description of the transaction.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The amount of the transaction.
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; } = default!;

        /// <summary>
        /// Whether the amount is a credit or debit.
        /// </summary>
        [JsonProperty("credit_or_debit")]
        public CreditOrDebit CreditOrDebit { get; set; } = default!;

        /// <summary>
        /// The ID of the source transaction.
        /// </summary>
        [JsonProperty("source_transaction_id")]
        public string SourceTransactionId { get; set; } = default!;

        /// <summary>
        /// The counterparty of the transaction.
        /// </summary>
        [JsonProperty("counterparty")]
        public string? Counterparty { get; set; }

        /// <summary>
        /// The reference of the transaction.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; set; }

        /// <summary>
        /// Type of transaction.
        /// </summary>
        [JsonProperty("transaction_type")]
        public BankFeedStatementTransactionType? TransactionType { get; set; }
    }
}