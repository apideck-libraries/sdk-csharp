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
    
    public class Address
    {

        /// <summary>
        /// Unique identifier for the address.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// The type of address.
        /// </summary>
        [JsonProperty("type")]
        public Models.Components.Type? Type { get; set; } = null;

        /// <summary>
        /// The address string. Some APIs don&apos;t provide structured address data.
        /// </summary>
        [JsonProperty("string")]
        public string? String { get; set; } = null;

        /// <summary>
        /// The name of the address.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// Line 1 of the address e.g. number, street, suite, apt #, etc.
        /// </summary>
        [JsonProperty("line1")]
        public string? Line1 { get; set; } = null;

        /// <summary>
        /// Line 2 of the address
        /// </summary>
        [JsonProperty("line2")]
        public string? Line2 { get; set; } = null;

        /// <summary>
        /// Line 3 of the address
        /// </summary>
        [JsonProperty("line3")]
        public string? Line3 { get; set; } = null;

        /// <summary>
        /// Line 4 of the address
        /// </summary>
        [JsonProperty("line4")]
        public string? Line4 { get; set; } = null;

        /// <summary>
        /// Street number
        /// </summary>
        [JsonProperty("street_number")]
        public string? StreetNumber { get; set; } = null;

        /// <summary>
        /// Name of city.
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; } = null;

        /// <summary>
        /// Name of state
        /// </summary>
        [JsonProperty("state")]
        public string? State { get; set; } = null;

        /// <summary>
        /// Zip code or equivalent.
        /// </summary>
        [JsonProperty("postal_code")]
        public string? PostalCode { get; set; } = null;

        /// <summary>
        /// country code according to ISO 3166-1 alpha-2.
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; } = null;

        /// <summary>
        /// Latitude of the address
        /// </summary>
        [JsonProperty("latitude")]
        public string? Latitude { get; set; } = null;

        /// <summary>
        /// Longitude of the address
        /// </summary>
        [JsonProperty("longitude")]
        public string? Longitude { get; set; } = null;

        /// <summary>
        /// Address field that holds a sublocality, such as a county
        /// </summary>
        [JsonProperty("county")]
        public string? County { get; set; } = null;

        /// <summary>
        /// Name of the contact person at the address
        /// </summary>
        [JsonProperty("contact_name")]
        public string? ContactName { get; set; } = null;

        /// <summary>
        /// Salutation of the contact person at the address
        /// </summary>
        [JsonProperty("salutation")]
        public string? Salutation { get; set; } = null;

        /// <summary>
        /// Phone number of the address
        /// </summary>
        [JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; } = null;

        /// <summary>
        /// Fax number of the address
        /// </summary>
        [JsonProperty("fax")]
        public string? Fax { get; set; } = null;

        /// <summary>
        /// Email address of the address
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; } = null;

        /// <summary>
        /// Website of the address
        /// </summary>
        [JsonProperty("website")]
        public string? Website { get; set; } = null;

        /// <summary>
        /// Additional notes
        /// </summary>
        [JsonProperty("notes")]
        public string? Notes { get; set; } = null;

        /// <summary>
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        [JsonProperty("row_version")]
        public string? RowVersion { get; set; } = null;
    }
}