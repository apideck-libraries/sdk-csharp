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
    
    public class VaultConnectionsDeleteRequest
    {

        /// <summary>
        /// ID of the consumer which you want to get or push data from
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=x-apideck-consumer-id")]
        public string? ConsumerId { get; set; }

        /// <summary>
        /// The ID of your Unify application
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=x-apideck-app-id")]
        public string? AppId { get; set; }

        /// <summary>
        /// Service ID of the resource to return
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=service_id")]
        public string ServiceId { get; set; } = default!;

        /// <summary>
        /// Unified API
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=unified_api")]
        public string UnifiedApi { get; set; } = default!;
    }
}