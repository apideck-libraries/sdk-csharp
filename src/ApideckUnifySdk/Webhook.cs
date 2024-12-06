//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace ApideckUnifySdk
{
    using ApideckUnifySdk.Models.Components;
    using ApideckUnifySdk.Models.Errors;
    using ApideckUnifySdk.Utils;
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
        private const string _sdkGenVersion = "2.472.1";
        private const string _openapiDocVersion = "10.8.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.0.4 2.472.1 10.8.3 ApideckUnifySdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<ApideckUnifySdk.Models.Components.Security>? _securitySource;
        public IWebhooks Webhooks { get; private set; }

        public Webhook(ISpeakeasyHttpClient client, Func<ApideckUnifySdk.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            Webhooks = new Webhooks(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}