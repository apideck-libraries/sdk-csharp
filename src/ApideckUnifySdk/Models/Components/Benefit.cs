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
    
    public class Benefit
    {

        /// <summary>
        /// The name of the benefit.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// The amount deducted for benefit.
        /// </summary>
        [JsonProperty("employee_deduction")]
        public double? EmployeeDeduction { get; set; } = null;

        /// <summary>
        /// The amount of employer contribution.
        /// </summary>
        [JsonProperty("employer_contribution")]
        public double? EmployerContribution { get; set; } = null;
    }
}