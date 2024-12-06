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
    using System;
    
    public class UserInput
    {

        /// <summary>
        /// The parent user id
        /// </summary>
        [JsonProperty("parent_id")]
        public string? ParentId { get; set; } = null;

        /// <summary>
        /// The username of the user
        /// </summary>
        [JsonProperty("username")]
        public string? Username { get; set; } = null;

        /// <summary>
        /// The first name of the person.
        /// </summary>
        [JsonProperty("first_name")]
        public string? FirstName { get; set; } = null;

        /// <summary>
        /// The last name of the person.
        /// </summary>
        [JsonProperty("last_name")]
        public string? LastName { get; set; } = null;

        /// <summary>
        /// The job title of the person.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// The division the person is currently in. Usually a collection of departments or teams or regions.
        /// </summary>
        [JsonProperty("division")]
        public string? Division { get; set; } = null;

        /// <summary>
        /// The department the person is currently in. <a href="https://developers.apideck.com/changelog">Deprecated</a> in favor of the dedicated department_id and department_name field.
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("department")]
        public string? Department { get; set; } = null;

        /// <summary>
        /// The name of the company.
        /// </summary>
        [JsonProperty("company_name")]
        public string? CompanyName { get; set; } = null;

        /// <summary>
        /// An Employee Number, Employee ID or Employee Code, is a unique number that has been assigned to each individual staff member within a company.
        /// </summary>
        [JsonProperty("employee_number")]
        public string? EmployeeNumber { get; set; } = null;

        /// <summary>
        /// A description of the object.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// The URL of the user&apos;s avatar
        /// </summary>
        [JsonProperty("image")]
        public string? Image { get; set; } = null;

        /// <summary>
        /// language code according to ISO 639-1. For the United States - EN
        /// </summary>
        [JsonProperty("language")]
        public string? Language { get; set; } = null;

        /// <summary>
        /// The status of the user
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; } = null;

        /// <summary>
        /// The password of the user
        /// </summary>
        [JsonProperty("password")]
        public string? Password { get; set; } = null;

        [JsonProperty("addresses")]
        public List<Address>? Addresses { get; set; }

        [JsonProperty("phone_numbers")]
        public List<PhoneNumber>? PhoneNumbers { get; set; }

        [JsonProperty("emails")]
        public List<Email> Emails { get; set; } = default!;

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }
    }
}