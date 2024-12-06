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
    using System;
    
    public class ActivitiesFilter
    {

        /// <summary>
        /// Company ID to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=company_id")]
        public string? CompanyId { get; set; }

        /// <summary>
        /// Owner ID to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// Primary contact ID to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=contact_id")]
        public string? ContactId { get; set; }

        [SpeakeasyMetadata("queryParam:name=updated_since")]
        public DateTime? UpdatedSince { get; set; }

        /// <summary>
        /// Type to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=type")]
        public string? Type { get; set; }
    }
}