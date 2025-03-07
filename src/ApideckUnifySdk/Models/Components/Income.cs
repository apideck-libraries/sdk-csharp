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
    
    /// <summary>
    /// The operating income accounts
    /// </summary>
    public class Income
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The account code of the account
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// The name of the account.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The type of profit and loss
        /// </summary>
        [JsonProperty("type")]
        public ProfitAndLossType? Type { get; set; } = null;

        /// <summary>
        /// The total amount of the transaction
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Include)]
        public double? Total { get; set; }

        [JsonProperty("records")]
        public object Records { get; set; } = default!;
    }
}