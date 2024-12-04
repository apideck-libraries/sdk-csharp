//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Unify
{
    using System;
    using Unify.Models.Components;
    using Unify.Models.Errors;
    using Unify.Utils;

    public interface ICrm
    {
        public ICompanies Companies { get; }
        public IContacts Contacts { get; }
        public IOpportunities Opportunities { get; }
        public ILeads Leads { get; }
        public IPipelines Pipelines { get; }
        public INotes Notes { get; }
        public IUsers Users { get; }
        public IActivities Activities { get; }
    }

    public class Crm: ICrm
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.3";
        private const string _sdkGenVersion = "2.470.1";
        private const string _openapiDocVersion = "10.8.1";
        private const string _userAgent = "speakeasy-sdk/csharp 0.0.3 2.470.1 10.8.1 Unify";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Unify.Models.Components.Security>? _securitySource;
        public ICompanies Companies { get; private set; }
        public IContacts Contacts { get; private set; }
        public IOpportunities Opportunities { get; private set; }
        public ILeads Leads { get; private set; }
        public IPipelines Pipelines { get; private set; }
        public INotes Notes { get; private set; }
        public IUsers Users { get; private set; }
        public IActivities Activities { get; private set; }

        public Crm(ISpeakeasyHttpClient client, Func<Unify.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            Companies = new Companies(_client, _securitySource, _serverUrl, SDKConfiguration);
            Contacts = new Contacts(_client, _securitySource, _serverUrl, SDKConfiguration);
            Opportunities = new Opportunities(_client, _securitySource, _serverUrl, SDKConfiguration);
            Leads = new Leads(_client, _securitySource, _serverUrl, SDKConfiguration);
            Pipelines = new Pipelines(_client, _securitySource, _serverUrl, SDKConfiguration);
            Notes = new Notes(_client, _securitySource, _serverUrl, SDKConfiguration);
            Users = new Users(_client, _securitySource, _serverUrl, SDKConfiguration);
            Activities = new Activities(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}