//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Apideck.Unify.SDK
{
    using Apideck.Unify.SDK.Models.Components;
    using Apideck.Unify.SDK.Models.Errors;
    using Apideck.Unify.SDK.Utils;
    using System;

    public interface IWebhook
    {
        public IWebhooks Webhooks { get; }
    }

    public class Webhook: IWebhook
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.4";
        private const string _sdkGenVersion = "2.471.2";
        private const string _openapiDocVersion = "10.8.2";
        private const string _userAgent = "speakeasy-sdk/csharp 0.0.4 2.471.2 10.8.2 Apideck.Unify.SDK";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Apideck.Unify.SDK.Models.Components.Security>? _securitySource;
        public IWebhooks Webhooks { get; private set; }

        public Webhook(ISpeakeasyHttpClient client, Func<Apideck.Unify.SDK.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            Webhooks = new Webhooks(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}