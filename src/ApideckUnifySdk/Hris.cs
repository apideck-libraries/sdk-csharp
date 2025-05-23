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
        private const string _sdkVersion = "0.10.3";
        private const string _sdkGenVersion = "2.605.6";
        private const string _openapiDocVersion = "10.16.7";
        private const string _userAgent = "speakeasy-sdk/csharp 0.10.3 2.605.6 10.16.7 ApideckUnifySdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<ApideckUnifySdk.Models.Components.Security>? _securitySource;
        public IEmployees Employees { get; private set; }
        public IApideckCompanies Companies { get; private set; }
        public IApideckDepartments Departments { get; private set; }
        public IPayrolls Payrolls { get; private set; }
        public IEmployeePayrolls EmployeePayrolls { get; private set; }
        public IEmployeeSchedules EmployeeSchedules { get; private set; }
        public ITimeOffRequests TimeOffRequests { get; private set; }

        public Hris(ISpeakeasyHttpClient client, Func<ApideckUnifySdk.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
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