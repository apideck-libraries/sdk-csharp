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
    using System;
    
    public class CustomersFilter
    {

        /// <summary>
        /// Company Name of customer to search for
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// Display Name of customer to search for
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// First name of customer to search for
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of customer to search for
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Email of customer to search for
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=email")]
        public string? Email { get; set; }

        /// <summary>
        /// Status of customer to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=status")]
        public CustomersFilterStatus? Status { get; set; } = null;

        [SpeakeasyMetadata("queryParam:name=updated_since")]
        public DateTime? UpdatedSince { get; set; }

        /// <summary>
        /// Supplier ID of customer to search for
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=supplier_id")]
        public string? SupplierId { get; set; }
    }
}