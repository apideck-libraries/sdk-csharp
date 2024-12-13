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
        /// Start date of the period.
        /// </summary>
        [JsonProperty("start_date")]
        public LocalDate? StartDate { get; set; }

        /// <summary>
        /// End date of the period.
        /// </summary>
        [JsonProperty("end_date")]
        public LocalDate? EndDate { get; set; }

        /// <summary>
        /// Total amount of the period.
        /// </summary>
        [JsonProperty("total_amount")]
        public double? TotalAmount { get; set; }

        [JsonProperty("balances_by_transaction")]
        public List<BalanceByTransaction>? BalancesByTransaction { get; set; }
    }
}