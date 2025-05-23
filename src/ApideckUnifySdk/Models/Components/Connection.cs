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
    using System.Collections.Generic;
    
    public class Connection
    {

        /// <summary>
        /// The unique identifier of the connection.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the service this connection belongs to.
        /// </summary>
        [JsonProperty("service_id")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// The name of the connection
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("tag_line")]
        public string? TagLine { get; set; }

        /// <summary>
        /// The unified API category where the connection belongs to.
        /// </summary>
        [JsonProperty("unified_api")]
        public string? UnifiedApi { get; set; }

        /// <summary>
        /// <a href="#section/Connection-state">Connection state flow</a>
        /// </summary>
        [JsonProperty("state")]
        public ConnectionState? State { get; set; }

        /// <summary>
        /// The current state of the Integration.
        /// </summary>
        [JsonProperty("integration_state")]
        public IntegrationState? IntegrationState { get; set; }

        /// <summary>
        /// Type of authorization used by the connector
        /// </summary>
        [JsonProperty("auth_type")]
        public AuthType? AuthType { get; set; }

        /// <summary>
        /// OAuth grant type used by the connector. More info: https://oauth.net/2/grant-types
        /// </summary>
        [JsonProperty("oauth_grant_type")]
        public OAuthGrantType? OauthGrantType { get; set; }

        /// <summary>
        /// Status of the connection.
        /// </summary>
        [JsonProperty("status")]
        public ConnectionStatus? Status { get; set; }

        /// <summary>
        /// Whether the connection is enabled or not. You can enable or disable a connection using the Update Connection API.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The website URL of the connection
        /// </summary>
        [JsonProperty("website")]
        public string? Website { get; set; }

        /// <summary>
        /// A visual icon of the connection, that will be shown in the Vault
        /// </summary>
        [JsonProperty("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// The logo of the connection, that will be shown in the Vault
        /// </summary>
        [JsonProperty("logo")]
        public string? Logo { get; set; }

        /// <summary>
        /// The OAuth redirect URI. Redirect your users to this URI to let them authorize your app in the connector&apos;s UI. Before you can use this URI, you must add `redirect_uri` as a query parameter to the `authorize_url`. Be sure to URL encode the `redirect_uri` part. Your users will be redirected to this `redirect_uri` after they granted access to your app in the connector&apos;s UI.
        /// </summary>
        [JsonProperty("authorize_url")]
        public string? AuthorizeUrl { get; set; } = null;

        /// <summary>
        /// The OAuth revoke URI. Redirect your users to this URI to revoke this connection. Before you can use this URI, you must add `redirect_uri` as a query parameter. Your users will be redirected to this `redirect_uri` after they granted access to your app in the connector&apos;s UI.
        /// </summary>
        [JsonProperty("revoke_url")]
        public string? RevokeUrl { get; set; } = null;

        /// <summary>
        /// Connection settings. Values will persist to `form_fields` with corresponding id
        /// </summary>
        [JsonProperty("settings")]
        public Dictionary<string, object>? Settings { get; set; } = null;

        /// <summary>
        /// Attach your own consumer specific metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, object>? Metadata { get; set; } = null;

        /// <summary>
        /// The settings that are wanted to create a connection.
        /// </summary>
        [JsonProperty("form_fields")]
        public List<FormField>? FormFields { get; set; }

        [JsonProperty("configuration")]
        public List<Configuration>? Configuration { get; set; }

        [JsonProperty("configurable_resources")]
        public List<string>? ConfigurableResources { get; set; }

        [JsonProperty("resource_schema_support")]
        public List<string>? ResourceSchemaSupport { get; set; }

        [JsonProperty("resource_settings_support")]
        public List<string>? ResourceSettingsSupport { get; set; }

        [JsonProperty("validation_support")]
        public bool? ValidationSupport { get; set; }

        [JsonProperty("schema_support")]
        public bool? SchemaSupport { get; set; }

        /// <summary>
        /// List of settings that are required to be configured on integration before authorization can occur
        /// </summary>
        [JsonProperty("settings_required_for_authorization")]
        public List<string>? SettingsRequiredForAuthorization { get; set; }

        [JsonProperty("subscriptions")]
        public List<WebhookSubscription>? Subscriptions { get; set; }

        /// <summary>
        /// Whether the connector has a guide available in the developer docs or not (https://docs.apideck.com/connectors/{service_id}/docs/consumer+connection).
        /// </summary>
        [JsonProperty("has_guide")]
        public bool? HasGuide { get; set; }

        [JsonProperty("created_at")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// List of custom mappings configured for this connection
        /// </summary>
        [JsonProperty("custom_mappings")]
        public List<CustomMapping>? CustomMappings { get; set; }

        [JsonProperty("updated_at")]
        public double? UpdatedAt { get; set; } = null;
    }
}