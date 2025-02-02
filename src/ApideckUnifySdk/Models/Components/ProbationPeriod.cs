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
    using Newtonsoft.Json;
    using NodaTime;
    
    public class ProbationPeriod
    {

        /// <summary>
        /// The date that the employee started their probation period at the company.
        /// </summary>
        [JsonProperty("start_date")]
        public LocalDate? StartDate { get; set; } = null;

        /// <summary>
        /// The date that the employee ended their probation period at the company.
        /// </summary>
        [JsonProperty("end_date")]
        public LocalDate? EndDate { get; set; } = null;
    }
}