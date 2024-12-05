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
    
    public class SalesDetails
    {

        [JsonProperty("unit_price")]
        public double? UnitPrice { get; set; } = null;

        /// <summary>
        /// Description of the unit type the item is sold as, ie: kg, hour.
        /// </summary>
        [JsonProperty("unit_of_measure")]
        public string? UnitOfMeasure { get; set; } = null;

        /// <summary>
        /// Amounts are including tax
        /// </summary>
        [JsonProperty("tax_inclusive")]
        public bool? TaxInclusive { get; set; } = null;

        [JsonProperty("tax_rate")]
        public LinkedTaxRate? TaxRate { get; set; }
    }
}