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
    
    public class Stages
    {

        /// <summary>
        /// The unique identifier of the Pipeline Stage.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// The name of the Pipeline Stage.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// The value of the Pipeline Stage.
        /// </summary>
        [JsonProperty("value")]
        public string? Value { get; set; } = null;

        /// <summary>
        /// The expected probability of winning an Opportunity in this Pipeline Stage. Valid values are [0-100].
        /// </summary>
        [JsonProperty("win_probability")]
        public long? WinProbability { get; set; } = null;

        /// <summary>
        /// The order in which the Pipeline Stage is displayed in the UI.
        /// </summary>
        [JsonProperty("display_order")]
        public long? DisplayOrder { get; set; } = null;
    }
}