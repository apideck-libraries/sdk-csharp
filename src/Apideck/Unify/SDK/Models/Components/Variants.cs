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
    using System.Collections.Generic;
    
    public class Variants
    {

        /// <summary>
        /// A unique identifier for the variant of the product.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// The name for the variant, used for displaying to customers.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// The price of the variant.
        /// </summary>
        [JsonProperty("price")]
        public string? Price { get; set; } = null;

        /// <summary>
        /// The stock keeping unit of the variant.
        /// </summary>
        [JsonProperty("sku")]
        public string? Sku { get; set; } = null;

        /// <summary>
        /// The quantity of the variant in stock.
        /// </summary>
        [JsonProperty("inventory_quantity")]
        public string? InventoryQuantity { get; set; } = null;

        /// <summary>
        /// The weight of the variant.
        /// </summary>
        [JsonProperty("weight")]
        public string? Weight { get; set; } = null;

        /// <summary>
        /// The unit of measurement for the weight of the variant.
        /// </summary>
        [JsonProperty("weight_unit")]
        public string? WeightUnit { get; set; } = null;

        [JsonProperty("options")]
        public List<EcommerceProductVariantsOptions>? Options { get; set; }

        [JsonProperty("images")]
        public List<EcommerceProductImages>? Images { get; set; }
    }
}