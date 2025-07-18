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
    using System.Collections.Generic;
    
    public class EcommerceProductOptions
    {

        /// <summary>
        /// A unique identifier for the option of the product.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// The name of the option for the product.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        [JsonProperty("values")]
        public List<string?>? Values { get; set; }
    }
}