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
    using Newtonsoft.Json;
    
    public class NetIncome
    {

        /// <summary>
        /// Total net income
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Include)]
        public double? Total { get; set; }

        [JsonProperty("records")]
        public object Records { get; set; } = default!;
    }
}