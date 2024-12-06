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
    using Newtonsoft.Json;
    
    public class Schedule
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The start date, inclusive, of the schedule period.
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; } = default!;

        /// <summary>
        /// The end date, inclusive, of the schedule period.
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; } = default!;

        [JsonProperty("work_pattern")]
        public WorkPattern WorkPattern { get; set; } = default!;
    }
}