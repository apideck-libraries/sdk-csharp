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
    using System.Collections.Generic;
    using Unify.Models.Components;
    using Unify.Utils;
    
    public class FormFieldOptionGroup
    {

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("label")]
        public string? Label { get; set; }

        [JsonProperty("options")]
        public List<SimpleFormFieldOption>? Options { get; set; }
    }
}