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

    public interface IFileStorage
    {
        public IFiles Files { get; }
        public IFolders Folders { get; }
        public ISharedLinks SharedLinks { get; }
        public IUploadSessions UploadSessions { get; }
        public IDrives Drives { get; }
        public IDriveGroups DriveGroups { get; }
    }

    public class FileStorage: IFileStorage
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
        public IFiles Files { get; private set; }
        public IFolders Folders { get; private set; }
        public ISharedLinks SharedLinks { get; private set; }
        public IUploadSessions UploadSessions { get; private set; }
        public IDrives Drives { get; private set; }
        public IDriveGroups DriveGroups { get; private set; }

        public FileStorage(ISpeakeasyHttpClient client, Func<Unify.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            Files = new Files(_client, _securitySource, _serverUrl, SDKConfiguration);
            Folders = new Folders(_client, _securitySource, _serverUrl, SDKConfiguration);
            SharedLinks = new SharedLinks(_client, _securitySource, _serverUrl, SDKConfiguration);
            UploadSessions = new UploadSessions(_client, _securitySource, _serverUrl, SDKConfiguration);
            Drives = new Drives(_client, _securitySource, _serverUrl, SDKConfiguration);
            DriveGroups = new DriveGroups(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}