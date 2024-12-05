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
    
    /// <summary>
    /// The customer this entity is linked to.
    /// </summary>
    public class LinkedEcommerceCustomer
    {

        /// <summary>
        /// The ID of the customer this entity is linked to.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string? Id { get; set; }

        /// <summary>
        /// Full name of the customer
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// First name of the customer
        /// </summary>
        [JsonProperty("first_name")]
        public string? FirstName { get; set; } = null;

        /// <summary>
        /// Last name of the customer
        /// </summary>
        [JsonProperty("last_name")]
        public string? LastName { get; set; } = null;

        /// <summary>
        /// Company name of the customer
        /// </summary>
        [JsonProperty("company_name")]
        public string? CompanyName { get; set; } = null;

        [JsonProperty("phone_numbers")]
        public List<PhoneNumber>? PhoneNumbers { get; set; }

        [JsonProperty("emails")]
        public List<Email>? Emails { get; set; }
    }
}