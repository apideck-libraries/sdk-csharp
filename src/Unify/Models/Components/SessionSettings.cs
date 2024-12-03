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
    using System.Collections.Generic;
    using Unify.Models.Components;
    using Unify.Utils;
    
    /// <summary>
    /// Settings to change the way the Vault is displayed.
    /// </summary>
    public class SessionSettings
    {

        /// <summary>
        /// Provide the IDs of the Unified APIs you want to be visible. Leaving it empty or omitting this field will show all Unified APIs.
        /// </summary>
        [JsonProperty("unified_apis")]
        public List<UnifiedApiId>? UnifiedApis { get; set; }

        /// <summary>
        /// A boolean that controls the display of the configurable resources for an integration. When set to true, the resource configuration options will be hidden and not shown to the user. When set to false, the resource configuration options will be displayed to the user.
        /// </summary>
        [JsonProperty("hide_resource_settings")]
        public bool? HideResourceSettings { get; set; } = false;

        /// <summary>
        /// Configure <a href="/apis/vault/reference#section/Get-Started">Vault</a> to show a banner informing the logged in user is in a test environment.
        /// </summary>
        [JsonProperty("sandbox_mode")]
        public bool? SandboxMode { get; set; } = false;

        /// <summary>
        /// Configure <a href="/apis/vault/reference#section/Get-Started">Vault</a> to run in isolation mode, meaning it only shows the connection settings and hides the navigation items.
        /// </summary>
        [JsonProperty("isolation_mode")]
        public bool? IsolationMode { get; set; } = false;

        /// <summary>
        /// The duration of time the session is valid for (maximum 1 week).
        /// </summary>
        [JsonProperty("session_length")]
        public string? SessionLength { get; set; } = "1h";

        /// <summary>
        /// Configure <a href="/apis/vault/reference#section/Get-Started">Vault</a> to show the logs page. Defaults to `true`.
        /// </summary>
        [JsonProperty("show_logs")]
        public bool? ShowLogs { get; set; } = true;

        /// <summary>
        /// Configure <a href="/apis/vault/reference#section/Get-Started">Vault</a> to show the suggestions page. Defaults to `false`.
        /// </summary>
        [JsonProperty("show_suggestions")]
        public bool? ShowSuggestions { get; set; } = false;

        /// <summary>
        /// Configure <a href="/apis/vault/reference#section/Get-Started">Vault</a> to show the sidebar. Defaults to `true`.
        /// </summary>
        [JsonProperty("show_sidebar")]
        public bool? ShowSidebar { get; set; } = true;

        /// <summary>
        /// Automatically redirect to redirect uri after the connection has been configured as callable. Defaults to `false`.
        /// </summary>
        [JsonProperty("auto_redirect")]
        public bool? AutoRedirect { get; set; } = false;

        /// <summary>
        /// Hide Apideck connection guides in <a href="/apis/vault/reference#section/Get-Started">Vault</a>. Defaults to `false`.
        /// </summary>
        [JsonProperty("hide_guides")]
        public bool? HideGuides { get; set; } = false;

        /// <summary>
        /// Hide actions from your users in <a href="/apis/vault/reference#section/Get-Started">Vault</a>. Actions in `allow_actions` will be shown on a connection in Vault.<br/>
        /// 
        /// <remarks>
        /// Available actions are: `delete`, `disconnect`, `reauthorize` and `disable`.<br/>
        /// Empty array will hide all actions. By default all actions are visible.
        /// </remarks>
        /// </summary>
        [JsonProperty("allow_actions")]
        public List<AllowActions>? AllowActions { get; set; }
    }
}