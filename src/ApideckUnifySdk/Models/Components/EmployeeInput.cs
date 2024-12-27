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
    using NodaTime;
    using System;
    using System.Collections.Generic;
    
    public class EmployeeInput
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

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
        /// The name used to display the employee, often a combination of their first and last names.
        /// </summary>
        [JsonProperty("display_name")]
        public string? DisplayName { get; set; } = null;

        /// <summary>
        /// The name the employee prefers to be addressed by, which may be different from their legal name.
        /// </summary>
        [JsonProperty("preferred_name")]
        public string? PreferredName { get; set; } = null;

        /// <summary>
        /// The initials of the person, usually derived from their first, middle, and last names.
        /// </summary>
        [JsonProperty("initials")]
        public string? Initials { get; set; } = null;

        /// <summary>
        /// A formal salutation for the person. For example, &apos;Mr&apos;, &apos;Mrs&apos;
        /// </summary>
        [JsonProperty("salutation")]
        public string? Salutation { get; set; } = null;

        /// <summary>
        /// The job title of the person.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// The marital status of the employee.
        /// </summary>
        [JsonProperty("marital_status")]
        public string? MaritalStatus { get; set; } = null;

        [JsonProperty("partner")]
        public PersonInput? Partner { get; set; }

        /// <summary>
        /// The division the person is currently in. Usually a collection of departments or teams or regions.
        /// </summary>
        [JsonProperty("division")]
        public string? Division { get; set; } = null;

        /// <summary>
        /// Unique identifier of the division this employee belongs to.
        /// </summary>
        [JsonProperty("division_id")]
        public string? DivisionId { get; set; } = null;

        /// <summary>
        /// The department the person is currently in. <a href="https://developers.apideck.com/changelog">Deprecated</a> in favor of the dedicated department_id and department_name field.
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("department")]
        public string? Department { get; set; } = null;

        /// <summary>
        /// Unique identifier of the department ID this employee belongs to.
        /// </summary>
        [JsonProperty("department_id")]
        public string? DepartmentId { get; set; } = null;

        /// <summary>
        /// Name of the department this employee belongs to.
        /// </summary>
        [JsonProperty("department_name")]
        public string? DepartmentName { get; set; } = null;

        /// <summary>
        /// The team the person is currently in.
        /// </summary>
        [JsonProperty("team")]
        public Team? Team { get; set; } = null;

        /// <summary>
        /// The unique identifier of the company.
        /// </summary>
        [JsonProperty("company_id")]
        public string? CompanyId { get; set; } = null;

        /// <summary>
        /// The name of the company.
        /// </summary>
        [JsonProperty("company_name")]
        public string? CompanyName { get; set; } = null;

        /// <summary>
        /// A Start Date is the date that the employee started working at the company
        /// </summary>
        [JsonProperty("employment_start_date")]
        public string? EmploymentStartDate { get; set; } = null;

        /// <summary>
        /// An End Date is the date that the employee ended working at the company
        /// </summary>
        [JsonProperty("employment_end_date")]
        public string? EmploymentEndDate { get; set; } = null;

        /// <summary>
        /// The reason because the employment ended.
        /// </summary>
        [JsonProperty("leaving_reason")]
        public LeavingReason? LeavingReason { get; set; } = null;

        /// <summary>
        /// An Employee Number, Employee ID or Employee Code, is a unique number that has been assigned to each individual staff member within a company.
        /// </summary>
        [JsonProperty("employee_number")]
        public string? EmployeeNumber { get; set; } = null;

        /// <summary>
        /// The employment status of the employee, indicating whether they are currently employed, inactive, terminated, or in another status.
        /// </summary>
        [JsonProperty("employment_status")]
        public EmploymentStatus? EmploymentStatus { get; set; } = null;

        [JsonProperty("employment_role")]
        public EmploymentRole? EmploymentRole { get; set; }

        /// <summary>
        /// The ethnicity of the employee
        /// </summary>
        [JsonProperty("ethnicity")]
        public string? Ethnicity { get; set; } = null;

        [JsonProperty("manager")]
        public Manager? Manager { get; set; }

        /// <summary>
        /// Direct reports is an array of ids that reflect the individuals in an organizational hierarchy who are directly supervised by this specific employee.
        /// </summary>
        [JsonProperty("direct_reports")]
        public List<string>? DirectReports { get; set; } = null;

        /// <summary>
        /// A unique identifier assigned by the government. This field is considered sensitive information and may be subject to special security and privacy restrictions.
        /// </summary>
        [JsonProperty("social_security_number")]
        public string? SocialSecurityNumber { get; set; } = null;

        /// <summary>
        /// The date of birth of the person.
        /// </summary>
        [JsonProperty("birthday")]
        public LocalDate? Birthday { get; set; } = null;

        /// <summary>
        /// The date the person deceased.
        /// </summary>
        [JsonProperty("deceased_on")]
        public LocalDate? DeceasedOn { get; set; } = null;

        /// <summary>
        /// Country code according to ISO 3166-1 alpha-2.
        /// </summary>
        [JsonProperty("country_of_birth")]
        public string? CountryOfBirth { get; set; } = null;

        /// <summary>
        /// A description of the object.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// The gender represents the gender identity of a person.
        /// </summary>
        [JsonProperty("gender")]
        public Gender? Gender { get; set; } = null;

        /// <summary>
        /// The preferred pronouns of the person.
        /// </summary>
        [JsonProperty("pronouns")]
        public string? Pronouns { get; set; } = null;

        /// <summary>
        /// language code according to ISO 639-1. For the United States - EN
        /// </summary>
        [JsonProperty("preferred_language")]
        public string? PreferredLanguage { get; set; } = null;

        [JsonProperty("languages")]
        public List<string>? Languages { get; set; }

        [JsonProperty("nationalities")]
        public List<string>? Nationalities { get; set; }

        /// <summary>
        /// The URL of the photo of a person.
        /// </summary>
        [JsonProperty("photo_url")]
        public string? PhotoUrl { get; set; } = null;

        /// <summary>
        /// The time zone related to the resource. The value is a string containing a standard time zone identifier, e.g. Europe/London.
        /// </summary>
        [JsonProperty("timezone")]
        public string? Timezone { get; set; } = null;

        /// <summary>
        /// When the employee is imported as a new hire, this field indicates what system (e.g. the name of the ATS) this employee was imported from.
        /// </summary>
        [JsonProperty("source")]
        public string? Source { get; set; } = null;

        /// <summary>
        /// Unique identifier of the employee in the system this employee was imported from (e.g. the ID in the ATS).
        /// </summary>
        [JsonProperty("source_id")]
        public string? SourceId { get; set; } = null;

        [JsonProperty("record_url")]
        public string? RecordUrl { get; set; } = null;

        [JsonProperty("jobs")]
        public List<EmployeeJobInput>? Jobs { get; set; } = null;

        [JsonProperty("compensations")]
        public List<EmployeeCompensationInput>? Compensations { get; set; } = null;

        /// <summary>
        /// Indicates if the employee works from a remote location.
        /// </summary>
        [JsonProperty("works_remote")]
        public bool? WorksRemote { get; set; } = null;

        [JsonProperty("addresses")]
        public List<Address>? Addresses { get; set; }

        [JsonProperty("phone_numbers")]
        public List<PhoneNumber>? PhoneNumbers { get; set; }

        [JsonProperty("emails")]
        public List<Email>? Emails { get; set; }

        [JsonProperty("custom_fields")]
        public List<CustomField>? CustomFields { get; set; }

        [JsonProperty("social_links")]
        public List<SocialLink>? SocialLinks { get; set; }

        [JsonProperty("bank_accounts")]
        public List<BankAccount>? BankAccounts { get; set; }

        [JsonProperty("tax_code")]
        public string? TaxCode { get; set; } = null;

        [JsonProperty("tax_id")]
        public string? TaxId { get; set; } = null;

        /// <summary>
        /// Indicate the employee&apos;s dietary preference.
        /// </summary>
        [JsonProperty("dietary_preference")]
        public string? DietaryPreference { get; set; } = null;

        /// <summary>
        /// Indicate the employee&apos;s food allergies.
        /// </summary>
        [JsonProperty("food_allergies")]
        public List<string>? FoodAllergies { get; set; } = null;

        [JsonProperty("probation_period")]
        public ProbationPeriod? ProbationPeriod { get; set; }

        [JsonProperty("tags")]
        public List<string>? Tags { get; set; } = null;

        /// <summary>
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        [JsonProperty("row_version")]
        public string? RowVersion { get; set; } = null;

        /// <summary>
        /// Flag to indicate if the object is deleted.
        /// </summary>
        [JsonProperty("deleted")]
        public bool? Deleted { get; set; } = null;

        /// <summary>
        /// The pass_through property allows passing service-specific, custom data or structured modifications in request body when creating or updating resources.
        /// </summary>
        [JsonProperty("pass_through")]
        public List<PassThroughBody>? PassThrough { get; set; }
    }
}