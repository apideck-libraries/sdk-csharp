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
    using ApideckUnifySdk.Utils;
    using Newtonsoft.Json;
    using System;
    
    public class PaymentAllocations
    {

        /// <summary>
        /// ID of the payment
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Amount of the payment allocated to the invoice
        /// </summary>
        [JsonProperty("allocated_amount")]
        public double? AllocatedAmount { get; set; } = null;

        /// <summary>
        /// Date of the payment
        /// </summary>
        [JsonProperty("date")]
        public DateTime? Date { get; set; } = null;
    }
}