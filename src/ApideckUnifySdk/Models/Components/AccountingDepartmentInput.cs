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
    
    public class AccountingDepartmentInput
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("parent_id")]
        public string? ParentId { get; set; } = null;

        /// <summary>
        /// The name of the department.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// Based on the status some functionality is enabled or disabled.
        /// </summary>
        [JsonProperty("status")]
        public DepartmentStatus? Status { get; set; }

        [JsonProperty("subsidiaries")]
        public List<SubsidiaryReferenceInput>? Subsidiaries { get; set; }

        /// <summary>
        /// The code of the department.
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        [JsonProperty("row_version")]
        public string? RowVersion { get; set; } = null;

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }
    }
}