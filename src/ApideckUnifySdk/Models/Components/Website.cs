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
    
    public class Website
    {

        /// <summary>
        /// Unique identifier for the website
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// The website URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The type of website
        /// </summary>
        [JsonProperty("type")]
        public WebsiteType? Type { get; set; } = null;
    }
}