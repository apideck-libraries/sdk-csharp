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
    
    public class Assignee
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("username")]
        public string? Username { get; set; } = null;
    }
}