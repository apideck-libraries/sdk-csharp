//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Unify.Models.Components
{
    using Newtonsoft.Json;
    using Unify.Utils;
    
    public class TlsSupport
    {

        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Description of the TLS support
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}