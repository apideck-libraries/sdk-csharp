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

    public interface ISms
    {
        public IMessages Messages { get; }
    }

    public class Sms: ISms
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.12.3";
        private const string _sdkGenVersion = "2.656.5";
        private const string _openapiDocVersion = "10.18.2";
        public IMessages Messages { get; private set; }

        public Sms(SDKConfig config)
        {
            SDKConfiguration = config;
            Messages = new Messages(SDKConfiguration);
        }
    }
}