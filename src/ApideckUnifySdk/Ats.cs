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
        private const string _sdkVersion = "0.12.3";
        private const string _sdkGenVersion = "2.656.5";
        private const string _openapiDocVersion = "10.18.2";
        public IJobs Jobs { get; private set; }
        public IApplicants Applicants { get; private set; }
        public IApplications Applications { get; private set; }

        public Ats(SDKConfig config)
        {
            SDKConfiguration = config;
            Jobs = new Jobs(SDKConfiguration);
            Applicants = new Applicants(SDKConfiguration);
            Applications = new Applications(SDKConfiguration);
        }
    }
}