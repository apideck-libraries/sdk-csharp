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

    public interface IIssueTracking
    {
        public ICollections Collections { get; }
        public ICollectionTickets CollectionTickets { get; }
        public ICollectionTicketComments CollectionTicketComments { get; }
        public ICollectionUsers CollectionUsers { get; }
        public ICollectionTags CollectionTags { get; }
    }

    public class IssueTracking: IIssueTracking
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.4.0";
        private const string _sdkGenVersion = "2.493.32";
        private const string _openapiDocVersion = "10.10.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.4.0 2.493.32 10.10.0 ApideckUnifySdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<ApideckUnifySdk.Models.Components.Security>? _securitySource;
        public ICollections Collections { get; private set; }
        public ICollectionTickets CollectionTickets { get; private set; }
        public ICollectionTicketComments CollectionTicketComments { get; private set; }
        public ICollectionUsers CollectionUsers { get; private set; }
        public ICollectionTags CollectionTags { get; private set; }

        public IssueTracking(ISpeakeasyHttpClient client, Func<ApideckUnifySdk.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            Collections = new Collections(_client, _securitySource, _serverUrl, SDKConfiguration);
            CollectionTickets = new CollectionTickets(_client, _securitySource, _serverUrl, SDKConfiguration);
            CollectionTicketComments = new CollectionTicketComments(_client, _securitySource, _serverUrl, SDKConfiguration);
            CollectionUsers = new CollectionUsers(_client, _securitySource, _serverUrl, SDKConfiguration);
            CollectionTags = new CollectionTags(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}