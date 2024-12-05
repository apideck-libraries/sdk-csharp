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
    
    public class PayrollsFilter
    {

        /// <summary>
        /// Return payrolls whose pay period is after the start date
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=start_date")]
        public string? StartDate { get; set; }

        /// <summary>
        /// Return payrolls whose pay period is before the end date
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=end_date")]
        public string? EndDate { get; set; }
    }
}