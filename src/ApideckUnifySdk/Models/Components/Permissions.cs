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
    /// Permissions the current user has on this file.
    /// </summary>
    public class Permissions
    {

        /// <summary>
        /// Whether the current user can download this file.
        /// </summary>
        [JsonProperty("download")]
        public bool? Download { get; set; }
    }
}