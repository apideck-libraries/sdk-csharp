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
    
    public class EcommerceOrdersFilter
    {

        /// <summary>
        /// Customer email address to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=email")]
        public string? Email { get; set; }

        /// <summary>
        /// Customer id to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=customer_id")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Minimum date the order was last modified
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=updated_since")]
        public string? UpdatedSince { get; set; }

        /// <summary>
        /// Minimum date the order was created
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=created_since")]
        public string? CreatedSince { get; set; }
    }
}