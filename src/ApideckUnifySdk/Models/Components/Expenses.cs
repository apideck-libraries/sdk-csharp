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
    
    public class Expenses
    {

        /// <summary>
        /// Total expense
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Include)]
        public double? Total { get; set; }

        [JsonProperty("records")]
        public object Records { get; set; } = default!;
    }
}