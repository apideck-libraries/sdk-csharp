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

    public interface IHris
    {
        public IEmployees Employees { get; }
        public IApideckCompanies Companies { get; }
        public IApideckDepartments Departments { get; }
        public IPayrolls Payrolls { get; }
        public IEmployeePayrolls EmployeePayrolls { get; }
        public IEmployeeSchedules EmployeeSchedules { get; }
        public ITimeOffRequests TimeOffRequests { get; }
    }

    public class Hris: IHris
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
        public IEmployees Employees { get; private set; }
        public IApideckCompanies Companies { get; private set; }
        public IApideckDepartments Departments { get; private set; }
        public IPayrolls Payrolls { get; private set; }
        public IEmployeePayrolls EmployeePayrolls { get; private set; }
        public IEmployeeSchedules EmployeeSchedules { get; private set; }
        public ITimeOffRequests TimeOffRequests { get; private set; }

        public Hris(ISpeakeasyHttpClient client, Func<Apideck.Unify.SDK.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            Employees = new Employees(_client, _securitySource, _serverUrl, SDKConfiguration);
            Companies = new ApideckCompanies(_client, _securitySource, _serverUrl, SDKConfiguration);
            Departments = new ApideckDepartments(_client, _securitySource, _serverUrl, SDKConfiguration);
            Payrolls = new Payrolls(_client, _securitySource, _serverUrl, SDKConfiguration);
            EmployeePayrolls = new EmployeePayrolls(_client, _securitySource, _serverUrl, SDKConfiguration);
            EmployeeSchedules = new EmployeeSchedules(_client, _securitySource, _serverUrl, SDKConfiguration);
            TimeOffRequests = new TimeOffRequests(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}