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
    
    /// <summary>
    /// A balance sheet assets account represents the financial position of a company at a specific point in time.
    /// </summary>
    public class BalanceSheetAssetsAccount
    {

        /// <summary>
        /// The unique identifier for the account.
        /// </summary>
        [JsonProperty("account_id")]
        public string? AccountId { get; set; }

        /// <summary>
        /// The account code of the account
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// The name of the account.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The amount or value of the item
        /// </summary>
        [JsonProperty("value")]
        public double? Value { get; set; }

        /// <summary>
        /// A list of balance sheet accounts
        /// </summary>
        [JsonProperty("items")]
        public object? Items { get; set; }
    }
}