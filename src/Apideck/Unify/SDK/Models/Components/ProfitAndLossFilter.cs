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
    
    public class ProfitAndLossFilter
    {

        /// <summary>
        /// Filter by customer id
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=customer_id")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Filter by start date. If start date is given, end date is required.
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=start_date")]
        public string? StartDate { get; set; }

        /// <summary>
        /// Filter by end date. If end date is given, start date is required.
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=end_date")]
        public string? EndDate { get; set; }
    }
}