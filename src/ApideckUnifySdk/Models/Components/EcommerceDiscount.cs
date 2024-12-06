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
    /// An object representing a discount applied to an ecommerce order or product.
    /// </summary>
    public class EcommerceDiscount
    {

        /// <summary>
        /// The code used to apply the discount.
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; } = null;

        /// <summary>
        /// The fixed amount of the discount.
        /// </summary>
        [JsonProperty("amount")]
        public string? Amount { get; set; } = null;

        /// <summary>
        /// The percentage of the discount.
        /// </summary>
        [JsonProperty("percentage")]
        public string? Percentage { get; set; } = null;
    }
}