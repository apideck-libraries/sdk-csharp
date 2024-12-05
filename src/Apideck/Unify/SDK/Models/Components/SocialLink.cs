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
    
    public class SocialLink
    {

        /// <summary>
        /// Unique identifier of the social link
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// URL of the social link, e.g. https://www.twitter.com/apideck
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Type of the social link, e.g. twitter
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; } = null;
    }
}