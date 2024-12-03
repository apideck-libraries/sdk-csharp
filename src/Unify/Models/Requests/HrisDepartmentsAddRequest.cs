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
    using Unify.Models.Components;
    using Unify.Utils;
    
    public class HrisDepartmentsAddRequest
    {

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public DepartmentInput Department { get; set; } = default!;

        /// <summary>
        /// Include raw response. Mostly used for debugging purposes
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=raw")]
        public bool? Raw { get; set; } = false;

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
        /// Provide the service id you want to call (e.g., pipedrive). Only needed when a consumer has activated multiple integrations for a Unified API.
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=x-apideck-service-id")]
        public string? ServiceId { get; set; }
    }
}