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
    
    public class RequestCountAllocation
    {

        [JsonProperty("unify")]
        public double? Unify { get; set; }

        [JsonProperty("proxy")]
        public double? Proxy { get; set; }

        [JsonProperty("vault")]
        public double? Vault { get; set; }
    }
}