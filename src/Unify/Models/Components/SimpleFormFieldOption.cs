//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Unify.Models.Components
{
    using Newtonsoft.Json;
    using Unify.Models.Components;
    using Unify.Utils;
    
    public class SimpleFormFieldOption
    {

        [JsonProperty("label")]
        public string? Label { get; set; }

        [JsonProperty("value")]
        public SimpleFormFieldOptionValue? Value { get; set; }
    }
}