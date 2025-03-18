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
    
    public class EmployeesFilter
    {

        /// <summary>
        /// Company ID to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=company_id")]
        public string? CompanyId { get; set; }

        /// <summary>
        /// Email to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=email")]
        public string? Email { get; set; }

        /// <summary>
        /// First Name to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Job title to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=title")]
        public string? Title { get; set; }

        /// <summary>
        /// Last Name to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Manager id to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=manager_id")]
        public string? ManagerId { get; set; }

        /// <summary>
        /// Employment status to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=employment_status")]
        public EmployeesFilterEmploymentStatus? EmploymentStatus { get; set; }

        /// <summary>
        /// Employee number to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=employee_number")]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// ID of the department to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// City to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=city")]
        public string? City { get; set; }
    }
}