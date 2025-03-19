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

    public interface IVault
    {
        public IConsumers Consumers { get; }
        public IConsumerRequestCounts ConsumerRequestCounts { get; }
        public IConnections Connections { get; }
        public IValidateConnection ValidateConnection { get; }
        public ICreateCallback CreateCallback { get; }
        public IConnectionSettings ConnectionSettings { get; }
        public ICustomFields CustomFields { get; }
        public IConnectionCustomMappings ConnectionCustomMappings { get; }
        public ICustomMappings CustomMappings { get; }
        public ISessions Sessions { get; }
        public ILogs Logs { get; }
    }

    public class Vault: IVault
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.7.1";
        private const string _sdkGenVersion = "2.556.1";
        private const string _openapiDocVersion = "10.13.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.7.1 2.556.1 10.13.0 ApideckUnifySdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<ApideckUnifySdk.Models.Components.Security>? _securitySource;
        public IConsumers Consumers { get; private set; }
        public IConsumerRequestCounts ConsumerRequestCounts { get; private set; }
        public IConnections Connections { get; private set; }
        public IValidateConnection ValidateConnection { get; private set; }
        public ICreateCallback CreateCallback { get; private set; }
        public IConnectionSettings ConnectionSettings { get; private set; }
        public ICustomFields CustomFields { get; private set; }
        public IConnectionCustomMappings ConnectionCustomMappings { get; private set; }
        public ICustomMappings CustomMappings { get; private set; }
        public ISessions Sessions { get; private set; }
        public ILogs Logs { get; private set; }

        public Vault(ISpeakeasyHttpClient client, Func<ApideckUnifySdk.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            Consumers = new Consumers(_client, _securitySource, _serverUrl, SDKConfiguration);
            ConsumerRequestCounts = new ConsumerRequestCounts(_client, _securitySource, _serverUrl, SDKConfiguration);
            Connections = new Connections(_client, _securitySource, _serverUrl, SDKConfiguration);
            ValidateConnection = new ValidateConnection(_client, _securitySource, _serverUrl, SDKConfiguration);
            CreateCallback = new CreateCallback(_client, _securitySource, _serverUrl, SDKConfiguration);
            ConnectionSettings = new ConnectionSettings(_client, _securitySource, _serverUrl, SDKConfiguration);
            CustomFields = new CustomFields(_client, _securitySource, _serverUrl, SDKConfiguration);
            ConnectionCustomMappings = new ConnectionCustomMappings(_client, _securitySource, _serverUrl, SDKConfiguration);
            CustomMappings = new CustomMappings(_client, _securitySource, _serverUrl, SDKConfiguration);
            Sessions = new Sessions(_client, _securitySource, _serverUrl, SDKConfiguration);
            Logs = new Logs(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}