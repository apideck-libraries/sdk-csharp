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
    
    /// <summary>
    /// Links to navigate to previous or next pages through the API
    /// </summary>
    public class Links
    {

        /// <summary>
        /// Link to navigate to the previous page through the API
        /// </summary>
        [JsonProperty("previous")]
        public string? Previous { get; set; } = null;

        /// <summary>
        /// Link to navigate to the current page through the API
        /// </summary>
        [JsonProperty("current")]
        public string? Current { get; set; }

        /// <summary>
        /// Link to navigate to the previous page through the API
        /// </summary>
        [JsonProperty("next")]
        public string? Next { get; set; } = null;
    }
}