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
    
    public class Stage
    {

        /// <summary>
        /// Stage the candidate should be in. If omitted, the default stage for this job will be used.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        [JsonProperty("name")]
        public string? Name { get; set; } = null;
    }
}