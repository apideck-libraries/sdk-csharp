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
    /// The rate at which requests for resources will be made to downstream.
    /// </summary>
    public class RequestRate
    {

        /// <summary>
        /// The number of requests per window unit.
        /// </summary>
        [JsonProperty("rate")]
        public long Rate { get; set; } = default!;

        /// <summary>
        /// Size of request window.
        /// </summary>
        [JsonProperty("size")]
        public long Size { get; set; } = default!;

        /// <summary>
        /// The window unit for the rate.
        /// </summary>
        [JsonProperty("unit")]
        public Unit Unit { get; set; } = default!;
    }
}