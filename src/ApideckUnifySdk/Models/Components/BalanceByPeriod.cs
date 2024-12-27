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
    using System.Collections.Generic;
    
    public class BalanceByPeriod
    {

        /// <summary>
        /// The starting date of the period. If not provided, it represents the oldest period, where all transactions due before the specified `end_date` are included.
        /// </summary>
        [JsonProperty("start_date")]
        public LocalDate? StartDate { get; set; } = null;

        /// <summary>
        /// The ending date of the period. If not provided, it represents an open-ended period starting from the `start_date`, typically capturing future-dated transactions that are not yet aged.
        /// </summary>
        [JsonProperty("end_date")]
        public LocalDate? EndDate { get; set; } = null;

        /// <summary>
        /// Total amount of the period.
        /// </summary>
        [JsonProperty("total_amount")]
        public double? TotalAmount { get; set; }

        [JsonProperty("balances_by_transaction")]
        public List<BalanceByTransaction>? BalancesByTransaction { get; set; }
    }
}