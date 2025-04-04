//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace ApideckUnifySdk.Models.Requests
{
    using ApideckUnifySdk.Utils;
    
    public class ConnectorApiResourcesOneRequest
    {

        /// <summary>
        /// The ID of your Unify application
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=x-apideck-app-id")]
        public string? AppId { get; set; }

        /// <summary>
        /// ID of the record you are acting upon.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// ID of the resource you are acting upon.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=resource_id")]
        public string ResourceId { get; set; } = default!;
    }
}