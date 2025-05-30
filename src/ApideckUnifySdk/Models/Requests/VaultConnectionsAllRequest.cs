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
    
    public class VaultConnectionsAllRequest
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
        /// Scope results to Unified API
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=api")]
        public string? Api { get; set; }

        /// <summary>
        /// Scopes results to connections that have been configured or not
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=configured")]
        public bool? Configured { get; set; }
    }
}