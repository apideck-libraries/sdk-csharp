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
    
    /// <summary>
    /// A single line item of an ecommerce order, representing a product or variant with associated options, quantity, and pricing information.
    /// </summary>
    public class EcommerceOrderLineItem
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// A unique identifier for the product associated with the line item.
        /// </summary>
        [JsonProperty("product_id")]
        public string? ProductId { get; set; } = null;

        /// <summary>
        /// A unique identifier for the variant of the product associated with the line item, if applicable.
        /// </summary>
        [JsonProperty("variant_id")]
        public string? VariantId { get; set; } = null;

        /// <summary>
        /// The SKU of the product or variant associated with the line item.
        /// </summary>
        [JsonProperty("sku")]
        public string? Sku { get; set; } = null;

        /// <summary>
        /// The name of the product or variant associated with the line item.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Include)]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the product or variant associated with the line item.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        [JsonProperty("options")]
        public List<Options>? Options { get; set; }

        /// <summary>
        /// The quantity of the product or variant associated with the line item.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Include)]
        public string? Quantity { get; set; }

        /// <summary>
        /// The unit price of the product or variant associated with the line item.
        /// </summary>
        [JsonProperty("unit_price")]
        public string? UnitPrice { get; set; } = null;

        /// <summary>
        /// The tax rate applied to the product or variant associated with the line item.
        /// </summary>
        [JsonProperty("tax_rate")]
        public string? TaxRate { get; set; } = null;

        /// <summary>
        /// The total tax amount applied to the product or variant associated with the line item.
        /// </summary>
        [JsonProperty("tax_amount")]
        public string? TaxAmount { get; set; } = null;

        /// <summary>
        /// Whether the line item has been refunded.
        /// </summary>
        [JsonProperty("is_refunded")]
        public bool? IsRefunded { get; set; } = null;

        /// <summary>
        /// The amount of the line item that has been refunded.
        /// </summary>
        [JsonProperty("refunded_amount")]
        public string? RefundedAmount { get; set; } = null;

        /// <summary>
        /// The quantity of the line item that has been refunded.
        /// </summary>
        [JsonProperty("refunded_quantity")]
        public string? RefundedQuantity { get; set; } = null;

        /// <summary>
        /// The sub total for the product(s) or variant associated with the line item, excluding taxes and discounts.
        /// </summary>
        [JsonProperty("sub_total")]
        public string? SubTotal { get; set; } = null;

        /// <summary>
        /// The total amount for the product(s) or variant associated with the line item, including taxes and discounts.
        /// </summary>
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Include)]
        public string? TotalAmount { get; set; }

        [JsonProperty("discounts")]
        public List<EcommerceDiscount>? Discounts { get; set; }
    }
}