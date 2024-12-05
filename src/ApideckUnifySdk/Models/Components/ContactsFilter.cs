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
    
    public class ContactsFilter
    {

        /// <summary>
        /// Name of the contact to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=name")]
        public string? Name { get; set; }

        /// <summary>
        /// First name of the contact to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the contact to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Email of the contact to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=email")]
        public string? Email { get; set; }

        /// <summary>
        /// Phone number of the contact to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Unique identifier for the associated company of the contact to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=company_id")]
        public string? CompanyId { get; set; }

        /// <summary>
        /// Unique identifier for the owner of the contact to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=owner_id")]
        public string? OwnerId { get; set; }
    }
}