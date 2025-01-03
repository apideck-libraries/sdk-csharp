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
    
    public class BalanceByTransaction
    {

        /// <summary>
        /// Unique identifier for the transaction.
        /// </summary>
        [JsonProperty("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// Date of the transaction.
        /// </summary>
        [JsonProperty("transaction_date")]
        public LocalDate? TransactionDate { get; set; }

        /// <summary>
        /// Type of the transaction.
        /// </summary>
        [JsonProperty("transaction_type")]
        public TransactionType? TransactionType { get; set; }

        /// <summary>
        /// Due date of the transaction.
        /// </summary>
        [JsonProperty("due_date")]
        public LocalDate? DueDate { get; set; }

        /// <summary>
        /// Original amount of the transaction.
        /// </summary>
        [JsonProperty("original_amount")]
        public double? OriginalAmount { get; set; }

        /// <summary>
        /// Outstanding balance of the transaction.
        /// </summary>
        [JsonProperty("outstanding_balance")]
        public double? OutstandingBalance { get; set; }

        /// <summary>
        /// Transaction number of the transaction.
        /// </summary>
        [JsonProperty("transaction_number")]
        public string? TransactionNumber { get; set; }
    }
}