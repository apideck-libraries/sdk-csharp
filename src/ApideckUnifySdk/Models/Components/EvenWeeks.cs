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
    
    public class EvenWeeks
    {

        [JsonProperty("hours_monday")]
        public double? HoursMonday { get; set; }

        [JsonProperty("hours_tuesday")]
        public double? HoursTuesday { get; set; }

        [JsonProperty("hours_wednesday")]
        public double? HoursWednesday { get; set; }

        [JsonProperty("hours_thursday")]
        public double? HoursThursday { get; set; }

        [JsonProperty("hours_friday")]
        public double? HoursFriday { get; set; }

        [JsonProperty("hours_saturday")]
        public double? HoursSaturday { get; set; }

        [JsonProperty("hours_sunday")]
        public double? HoursSunday { get; set; }
    }
}