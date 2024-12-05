//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace ApideckUnifySdk.Models.Components
{
    using ApideckUnifySdk.Models.Components;
    using ApideckUnifySdk.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class ActivityInput
    {

        /// <summary>
        /// The date and time of the activity
        /// </summary>
        [JsonProperty("activity_datetime")]
        public string? ActivityDatetime { get; set; } = null;

        /// <summary>
        /// The duration of the activity in seconds
        /// </summary>
        [JsonProperty("duration_seconds")]
        public long? DurationSeconds { get; set; } = null;

        /// <summary>
        /// The user related to the activity
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; } = null;

        /// <summary>
        /// The account related to the activity
        /// </summary>
        [JsonProperty("account_id")]
        public string? AccountId { get; set; } = null;

        /// <summary>
        /// The contact related to the activity
        /// </summary>
        [JsonProperty("contact_id")]
        public string? ContactId { get; set; } = null;

        /// <summary>
        /// The company related to the activity
        /// </summary>
        [JsonProperty("company_id")]
        public string? CompanyId { get; set; } = null;

        /// <summary>
        /// The opportunity related to the activity
        /// </summary>
        [JsonProperty("opportunity_id")]
        public string? OpportunityId { get; set; } = null;

        /// <summary>
        /// The lead related to the activity
        /// </summary>
        [JsonProperty("lead_id")]
        public string? LeadId { get; set; } = null;

        /// <summary>
        /// The owner of the activity
        /// </summary>
        [JsonProperty("owner_id")]
        public string? OwnerId { get; set; } = null;

        /// <summary>
        /// The campaign related to the activity
        /// </summary>
        [JsonProperty("campaign_id")]
        public string? CampaignId { get; set; } = null;

        /// <summary>
        /// The case related to the activity
        /// </summary>
        [JsonProperty("case_id")]
        public string? CaseId { get; set; } = null;

        /// <summary>
        /// The asset related to the activity
        /// </summary>
        [JsonProperty("asset_id")]
        public string? AssetId { get; set; } = null;

        /// <summary>
        /// The contract related to the activity
        /// </summary>
        [JsonProperty("contract_id")]
        public string? ContractId { get; set; } = null;

        /// <summary>
        /// The product related to the activity
        /// </summary>
        [JsonProperty("product_id")]
        public string? ProductId { get; set; } = null;

        /// <summary>
        /// The solution related to the activity
        /// </summary>
        [JsonProperty("solution_id")]
        public string? SolutionId { get; set; } = null;

        /// <summary>
        /// The custom object related to the activity
        /// </summary>
        [JsonProperty("custom_object_id")]
        public string? CustomObjectId { get; set; } = null;

        /// <summary>
        /// The type of the activity
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Include)]
        public ActivityType? Type { get; set; }

        /// <summary>
        /// The title of the activity
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// A description of the activity
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// An internal note about the activity
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; set; } = null;

        /// <summary>
        /// The location of the activity
        /// </summary>
        [JsonProperty("location")]
        public string? Location { get; set; } = null;

        [JsonProperty("location_address")]
        public Address? LocationAddress { get; set; }

        /// <summary>
        /// Whether the Activity is an all day event or not
        /// </summary>
        [JsonProperty("all_day_event")]
        public bool? AllDayEvent { get; set; } = null;

        /// <summary>
        /// Whether the Activity is private or not
        /// </summary>
        [JsonProperty("private")]
        public bool? Private { get; set; } = null;

        /// <summary>
        /// Whether the Activity is a group event or not
        /// </summary>
        [JsonProperty("group_event")]
        public bool? GroupEvent { get; set; } = null;

        /// <summary>
        /// The sub type of the group event
        /// </summary>
        [JsonProperty("event_sub_type")]
        public string? EventSubType { get; set; } = null;

        /// <summary>
        /// The type of the group event
        /// </summary>
        [JsonProperty("group_event_type")]
        public string? GroupEventType { get; set; } = null;

        /// <summary>
        /// Whether the activity is a child of another activity or not
        /// </summary>
        [JsonProperty("child")]
        public bool? Child { get; set; } = null;

        /// <summary>
        /// Whether the activity is archived or not
        /// </summary>
        [JsonProperty("archived")]
        public bool? Archived { get; set; } = null;

        /// <summary>
        /// Whether the activity is deleted or not
        /// </summary>
        [JsonProperty("deleted")]
        public bool? Deleted { get; set; } = null;

        [JsonProperty("show_as")]
        public ShowAs? ShowAs { get; set; } = null;

        /// <summary>
        /// Whether the Activity is done or not
        /// </summary>
        [JsonProperty("done")]
        public bool? Done { get; set; } = null;

        /// <summary>
        /// The start date and time of the activity
        /// </summary>
        [JsonProperty("start_datetime")]
        public string? StartDatetime { get; set; } = null;

        /// <summary>
        /// The end date and time of the activity
        /// </summary>
        [JsonProperty("end_datetime")]
        public string? EndDatetime { get; set; } = null;

        /// <summary>
        /// The date of the activity
        /// </summary>
        [JsonProperty("activity_date")]
        public string? ActivityDate { get; set; } = null;

        /// <summary>
        /// The end date of the activity
        /// </summary>
        [JsonProperty("end_date")]
        public string? EndDate { get; set; } = null;

        /// <summary>
        /// Whether the activity is recurrent or not
        /// </summary>
        [JsonProperty("recurrent")]
        public bool? Recurrent { get; set; }

        /// <summary>
        /// The date and time of the reminder
        /// </summary>
        [JsonProperty("reminder_datetime")]
        public string? ReminderDatetime { get; set; } = null;

        /// <summary>
        /// Whether the reminder is set or not
        /// </summary>
        [JsonProperty("reminder_set")]
        public bool? ReminderSet { get; set; } = null;

        /// <summary>
        /// The URL of the video conference
        /// </summary>
        [JsonProperty("video_conference_url")]
        public string? VideoConferenceUrl { get; set; } = null;

        /// <summary>
        /// The ID of the video conference
        /// </summary>
        [JsonProperty("video_conference_id")]
        public string? VideoConferenceId { get; set; } = null;

        /// <summary>
        /// Custom fields of the activity
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<CustomField>? CustomFields { get; set; }

        [JsonProperty("attendees")]
        public List<ActivityAttendeeInput>? Attendees { get; set; }

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }
    }
}