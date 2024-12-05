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
    using Apideck.Unify.SDK.Models.Components;
    using Apideck.Unify.SDK.Utils;
    using Newtonsoft.Json;
    
    public class IssueTrackingCollectionTicketCommentsUpdateResponse
    {

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;

        /// <summary>
        /// Update a Comment
        /// </summary>
        public UpdateCommentResponse? UpdateCommentResponse { get; set; }

        /// <summary>
        /// Unexpected error
        /// </summary>
        public UnexpectedErrorResponse? UnexpectedErrorResponse { get; set; }
    }
}