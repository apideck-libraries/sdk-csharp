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
    
    public class LeadsFilter
    {

        /// <summary>
        /// Name of the lead to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=name")]
        public string? Name { get; set; }

        /// <summary>
        /// First name of the lead to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the lead to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// E-mail of the lead to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=email")]
        public string? Email { get; set; }

        /// <summary>
        /// Phone number of the lead to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=phone_number")]
        public string? PhoneNumber { get; set; }
    }
}