//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Apideck.Unify.SDK.Models.Requests
{
    using Apideck.Unify.SDK.Utils;
    
    public class SmsMessagesAllRequest
    {

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

        /// <summary>
        /// Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=cursor")]
        public string? Cursor { get; set; } = null;

        /// <summary>
        /// Number of results to return. Minimum 1, Maximum 200, Default 20
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=limit")]
        public long? Limit { get; set; } = 20;

        /// <summary>
        /// The &apos;fields&apos; parameter allows API users to specify the fields they want to include in the API response. If this parameter is not present, the API will return all available fields. If this parameter is present, only the fields specified in the comma-separated string will be included in the response. Nested properties can also be requested by using a dot notation. &lt;br /&gt;&lt;br /&gt;Example: `fields=name,email,addresses.city`&lt;br /&gt;&lt;br /&gt;In the example above, the response will only include the fields &quot;name&quot;, &quot;email&quot; and &quot;addresses.city&quot;. If any other fields are available, they will be excluded.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=fields")]
        public string? Fields { get; set; } = null;
    }
}