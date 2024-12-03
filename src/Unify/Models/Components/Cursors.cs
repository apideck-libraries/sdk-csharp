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
    
    /// <summary>
    /// Cursors to navigate to previous or next pages through the API
    /// </summary>
    public class Cursors
    {

        /// <summary>
        /// Cursor to navigate to the previous page of results through the API
        /// </summary>
        [JsonProperty("previous")]
        public string? Previous { get; set; } = null;

        /// <summary>
        /// Cursor to navigate to the current page of results through the API
        /// </summary>
        [JsonProperty("current")]
        public string? Current { get; set; } = null;

        /// <summary>
        /// Cursor to navigate to the next page of results through the API
        /// </summary>
        [JsonProperty("next")]
        public string? Next { get; set; } = null;
    }
}