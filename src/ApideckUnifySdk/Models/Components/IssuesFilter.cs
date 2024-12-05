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
    using ApideckUnifySdk.Utils;
    using System.Collections.Generic;
    using System;
    
    public class IssuesFilter
    {

        /// <summary>
        /// Filter by ticket status, can be `open`, `closed` or `all`. Will passthrough if none of the above match
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=status")]
        public List<string>? Status { get; set; }

        /// <summary>
        /// Only return tickets since a specific date
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=since")]
        public DateTime? Since { get; set; }

        /// <summary>
        /// Only return tickets assigned to a specific user
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=assignee_id")]
        public string? AssigneeId { get; set; }
    }
}