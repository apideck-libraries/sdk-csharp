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
    
    public class Components
    {

        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("rate")]
        public double? Rate { get; set; } = null;

        [JsonProperty("compound")]
        public bool? Compound { get; set; } = null;
    }
}