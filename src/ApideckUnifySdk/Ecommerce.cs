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

    public interface IEcommerce
    {
        public IOrders Orders { get; }
        public IProducts Products { get; }
        public IApideckCustomers Customers { get; }
        public IStores Stores { get; }
    }

    public class Ecommerce: IEcommerce
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.4.1";
        private const string _sdkGenVersion = "2.493.32";
        private const string _openapiDocVersion = "10.10.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.4.1 2.493.32 10.10.0 ApideckUnifySdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<ApideckUnifySdk.Models.Components.Security>? _securitySource;
        public IOrders Orders { get; private set; }
        public IProducts Products { get; private set; }
        public IApideckCustomers Customers { get; private set; }
        public IStores Stores { get; private set; }

        public Ecommerce(ISpeakeasyHttpClient client, Func<ApideckUnifySdk.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            Orders = new Orders(_client, _securitySource, _serverUrl, SDKConfiguration);
            Products = new Products(_client, _securitySource, _serverUrl, SDKConfiguration);
            Customers = new ApideckCustomers(_client, _securitySource, _serverUrl, SDKConfiguration);
            Stores = new Stores(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}