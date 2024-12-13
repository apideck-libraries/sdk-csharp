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
    using ApideckUnifySdk.Hooks;
    using ApideckUnifySdk.Models.Components;
    using ApideckUnifySdk.Models.Errors;
    using ApideckUnifySdk.Utils.Retries;
    using ApideckUnifySdk.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Apideck: The Apideck OpenAPI Spec: SDK Optimized
    /// 
    /// <see>https://developers.apideck.com} - Apideck Developer Docs</see>
    /// </summary>
    public interface IApideck
    {
        public IAccounting Accounting { get; }
        public IAts Ats { get; }
        public ICrm Crm { get; }
        public IEcommerce Ecommerce { get; }
        public IFileStorage FileStorage { get; }
        public IHris Hris { get; }
        public ISms Sms { get; }
        public IIssueTracking IssueTracking { get; }
        public IConnector Connector { get; }
        public IVault Vault { get; }
        public IWebhook Webhook { get; }
    }

    public class SDKConfig
    {
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "https://unify.apideck.com",
        };

        public string ServerUrl = "";
        public int ServerIndex = 0;
        public string? ConsumerId;
        public string? AppId;
        public SDKHooks Hooks = new SDKHooks();
        public RetryConfig? RetryConfig = null;

        public string GetTemplatedServerUrl()
        {
            if (!String.IsNullOrEmpty(this.ServerUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.ServerUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.ServerIndex], new Dictionary<string, string>());
        }

        public ISpeakeasyHttpClient InitHooks(ISpeakeasyHttpClient client)
        {
            string preHooksUrl = GetTemplatedServerUrl();
            var (postHooksUrl, postHooksClient) = this.Hooks.SDKInit(preHooksUrl, client);
            if (preHooksUrl != postHooksUrl)
            {
                this.ServerUrl = postHooksUrl;
            }
            return postHooksClient;
        }
    }

    /// <summary>
    /// Apideck: The Apideck OpenAPI Spec: SDK Optimized
    /// 
    /// <see>https://developers.apideck.com} - Apideck Developer Docs</see>
    /// </summary>
    public class Apideck: IApideck
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.0";
        private const string _sdkGenVersion = "2.477.4";
        private const string _openapiDocVersion = "10.9.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.0 2.477.4 10.9.0 ApideckUnifySdk";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _client;
        private Func<ApideckUnifySdk.Models.Components.Security>? _securitySource;
        public IAccounting Accounting { get; private set; }
        public IAts Ats { get; private set; }
        public ICrm Crm { get; private set; }
        public IEcommerce Ecommerce { get; private set; }
        public IFileStorage FileStorage { get; private set; }
        public IHris Hris { get; private set; }
        public ISms Sms { get; private set; }
        public IIssueTracking IssueTracking { get; private set; }
        public IConnector Connector { get; private set; }
        public IVault Vault { get; private set; }
        public IWebhook Webhook { get; private set; }

        public Apideck(string? apiKey = null, Func<string>? apiKeySource = null, string? consumerId = null, string? appId = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null, RetryConfig? retryConfig = null)
        {
            if (serverIndex != null)
            {
                if (serverIndex.Value < 0 || serverIndex.Value >= SDKConfig.ServerList.Length)
                {
                    throw new Exception($"Invalid server index {serverIndex.Value}");
                }
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _client = client ?? new SpeakeasyHttpClient();

            if(apiKeySource != null)
            {
                _securitySource = () => new ApideckUnifySdk.Models.Components.Security() { ApiKey = apiKeySource() };
            }
            else if(apiKey != null)
            {
                _securitySource = () => new ApideckUnifySdk.Models.Components.Security() { ApiKey = apiKey };
            }
            else
            {
                throw new Exception("apiKey and apiKeySource cannot both be null");
            }

            SDKConfiguration = new SDKConfig()
            {
                ConsumerId = consumerId,
                AppId = appId,
                ServerIndex = _serverIndex,
                ServerUrl = _serverUrl,
                RetryConfig = retryConfig
            };

            _client = SDKConfiguration.InitHooks(_client);


            Accounting = new Accounting(_client, _securitySource, _serverUrl, SDKConfiguration);


            Ats = new Ats(_client, _securitySource, _serverUrl, SDKConfiguration);


            Crm = new Crm(_client, _securitySource, _serverUrl, SDKConfiguration);


            Ecommerce = new Ecommerce(_client, _securitySource, _serverUrl, SDKConfiguration);


            FileStorage = new FileStorage(_client, _securitySource, _serverUrl, SDKConfiguration);


            Hris = new Hris(_client, _securitySource, _serverUrl, SDKConfiguration);


            Sms = new Sms(_client, _securitySource, _serverUrl, SDKConfiguration);


            IssueTracking = new IssueTracking(_client, _securitySource, _serverUrl, SDKConfiguration);


            Connector = new Connector(_client, _securitySource, _serverUrl, SDKConfiguration);


            Vault = new Vault(_client, _securitySource, _serverUrl, SDKConfiguration);


            Webhook = new Webhook(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}