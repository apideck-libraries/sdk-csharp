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
    using NodaTime;
    
    public class PersonInput
    {

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
        /// Middle name of the person.
        /// </summary>
        [JsonProperty("middle_name")]
        public string? MiddleName { get; set; } = null;

        /// <summary>
        /// The gender represents the gender identity of a person.
        /// </summary>
        [JsonProperty("gender")]
        public Gender? Gender { get; set; } = null;

        /// <summary>
        /// Initials of the person
        /// </summary>
        [JsonProperty("initials")]
        public string? Initials { get; set; } = null;

        /// <summary>
        /// Date of birth
        /// </summary>
        [JsonProperty("birthday")]
        public LocalDate? Birthday { get; set; } = null;

        /// <summary>
        /// Date of death
        /// </summary>
        [JsonProperty("deceased_on")]
        public LocalDate? DeceasedOn { get; set; } = null;
    }
}