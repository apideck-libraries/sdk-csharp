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
    
    public class CreateCallbackState
    {

        /// <summary>
        /// The redirect URI to be used after the connection is created.
        /// </summary>
        [JsonProperty("redirect_uri")]
        public string? RedirectUri { get; set; }
    }
}