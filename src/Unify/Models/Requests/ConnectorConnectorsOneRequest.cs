//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Unify.Models.Requests
{
    using Unify.Utils;
    
    public class ConnectorConnectorsOneRequest
    {

        /// <summary>
        /// ID of the record you are acting upon.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The ID of your Unify application
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=x-apideck-app-id")]
        public string? AppId { get; set; }
    }
}