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

    public interface IAts
    {
        public IJobs Jobs { get; }
        public IApplicants Applicants { get; }
        public IApplications Applications { get; }
    }

    public class Ats: IAts
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.9.0";
        private const string _sdkGenVersion = "2.570.3";
        private const string _openapiDocVersion = "10.15.2";
        private const string _userAgent = "speakeasy-sdk/csharp 0.9.0 2.570.3 10.15.2 ApideckUnifySdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<ApideckUnifySdk.Models.Components.Security>? _securitySource;
        public IJobs Jobs { get; private set; }
        public IApplicants Applicants { get; private set; }
        public IApplications Applications { get; private set; }

        public Ats(ISpeakeasyHttpClient client, Func<ApideckUnifySdk.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            Jobs = new Jobs(_client, _securitySource, _serverUrl, SDKConfiguration);
            Applicants = new Applicants(_client, _securitySource, _serverUrl, SDKConfiguration);
            Applications = new Applications(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}