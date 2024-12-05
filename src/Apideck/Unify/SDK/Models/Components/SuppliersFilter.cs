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
    using Apideck.Unify.SDK.Utils;
    using System;
    
    public class SuppliersFilter
    {

        /// <summary>
        /// Company Name of supplier to search for
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// Display Name of supplier to search for
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// First name of supplier to search for
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of supplier to search for
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Email of supplier to search for
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=email")]
        public string? Email { get; set; }

        [SpeakeasyMetadata("queryParam:name=updated_since")]
        public DateTime? UpdatedSince { get; set; }
    }
}