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
    
    public class ApisFilter
    {

        /// <summary>
        /// Status of the API. APIs with status live or beta are callable.
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=status")]
        public ApiStatus? Status { get; set; }
    }
}