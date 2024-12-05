//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Apideck.Unify.SDK.Models.Components
{
    using Apideck.Unify.SDK.Models.Components;
    using Apideck.Unify.SDK.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    
    public class Message
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The phone number that initiated the message.
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; } = default!;

        /// <summary>
        /// The phone number that received the message.
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; } = default!;

        [JsonProperty("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The message text.
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; } = default!;

        /// <summary>
        /// Set to sms for SMS messages and mms for MMS messages.
        /// </summary>
        [JsonProperty("type")]
        public MessageType? Type { get; set; }

        /// <summary>
        /// The number of units that make up the complete message. Messages can be split up due to the constraints of the message size.
        /// </summary>
        [JsonProperty("number_of_units")]
        public long? NumberOfUnits { get; set; }

        /// <summary>
        /// The number of media files associated with the message.
        /// </summary>
        [JsonProperty("number_of_media_files")]
        public long? NumberOfMediaFiles { get; set; }

        /// <summary>
        /// The direction of the message.
        /// </summary>
        [JsonProperty("direction")]
        public Direction? Direction { get; set; }

        /// <summary>
        /// Status of the delivery of the message.
        /// </summary>
        [JsonProperty("status")]
        public MessageStatus? Status { get; set; }

        /// <summary>
        /// The scheduled date and time of the message.
        /// </summary>
        [JsonProperty("scheduled_at")]
        public DateTime? ScheduledAt { get; set; }

        /// <summary>
        /// The date and time that the message was sent
        /// </summary>
        [JsonProperty("sent_at")]
        public DateTime? SentAt { get; set; }

        /// <summary>
        /// Define a webhook to receive delivery notifications.
        /// </summary>
        [JsonProperty("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// A client reference.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; set; }

        /// <summary>
        /// Price of the message.
        /// </summary>
        [JsonProperty("price")]
        public Price? Price { get; set; }

        /// <summary>
        /// The error returned if your message status is failed or undelivered.
        /// </summary>
        [JsonProperty("error")]
        public Error? Error { get; set; }

        /// <summary>
        /// The ID of the Messaging Service used with the message. In case of Plivo this links to the Powerpack ID.
        /// </summary>
        [JsonProperty("messaging_service_id")]
        public string? MessagingServiceId { get; set; }

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        [JsonProperty("custom_mappings")]
        public Models.Components.CustomMappings? CustomMappings { get; set; } = null;

        /// <summary>
        /// The user who last updated the object.
        /// </summary>
        [JsonProperty("updated_by")]
        public string? UpdatedBy { get; set; } = null;

        /// <summary>
        /// The user who created the object.
        /// </summary>
        [JsonProperty("created_by")]
        public string? CreatedBy { get; set; } = null;

        /// <summary>
        /// The date and time when the object was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }
    }
}