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
    
    public class WebhookWebhooksAddRequest
    {

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public CreateWebhookRequest CreateWebhookRequest { get; set; } = default!;

        /// <summary>
        /// The ID of your Unify application
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=x-apideck-app-id")]
        public string? AppId { get; set; }
    }
}