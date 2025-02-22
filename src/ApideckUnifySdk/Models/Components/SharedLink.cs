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
    using System;
    using System.Collections.Generic;
    
    public class SharedLink
    {

        /// <summary>
        /// The URL that can be used to view the file.
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; } = null;

        /// <summary>
        /// The URL that can be used to download the file.
        /// </summary>
        [JsonProperty("download_url")]
        public string? DownloadUrl { get; set; } = null;

        [JsonProperty("target")]
        public SharedLinkTarget? Target { get; set; }

        /// <summary>
        /// The scope of the shared link.
        /// </summary>
        [JsonProperty("scope")]
        public Scope? Scope { get; set; } = null;

        /// <summary>
        /// Indicated if the shared link is password protected.
        /// </summary>
        [JsonProperty("password_protected")]
        public bool? PasswordProtected { get; set; } = null;

        [JsonProperty("expires_at")]
        public DateTime? ExpiresAt { get; set; } = null;

        /// <summary>
        /// The date and time when the object was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }
    }
}