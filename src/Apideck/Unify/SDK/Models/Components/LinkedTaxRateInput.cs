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
    using Apideck.Unify.SDK.Utils;
    using Newtonsoft.Json;
    
    public class LinkedTaxRateInput
    {

        /// <summary>
        /// The ID of the object.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// Rate of the tax rate
        /// </summary>
        [JsonProperty("rate")]
        public double? Rate { get; set; } = null;
    }
}