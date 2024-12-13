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
    
    public class AgedReportFilter
    {

        /// <summary>
        /// Filter by customer id
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=customer_id")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// The cutoff date for considering transactions
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=report_as_of_date")]
        public string? ReportAsOfDate { get; set; }

        /// <summary>
        /// Number of periods to split the aged creditors report into
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=period_count")]
        public long? PeriodCount { get; set; }

        /// <summary>
        /// Length of each period in days
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=period_length")]
        public long? PeriodLength { get; set; }
    }
}