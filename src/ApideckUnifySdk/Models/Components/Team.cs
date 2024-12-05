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
    /// The team the person is currently in.
    /// </summary>
    public class Team
    {

        /// <summary>
        /// The unique identifier of the team.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// The name of the team.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;
    }
}