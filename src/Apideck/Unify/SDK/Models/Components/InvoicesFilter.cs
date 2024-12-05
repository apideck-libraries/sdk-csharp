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
    using System;
    
    public class InvoicesFilter
    {

        [SpeakeasyMetadata("queryParam:name=updated_since")]
        public DateTime? UpdatedSince { get; set; }

        [SpeakeasyMetadata("queryParam:name=created_since")]
        public DateTime? CreatedSince { get; set; }

        /// <summary>
        /// Invoice number to search for
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=number")]
        public string? Number { get; set; }
    }
}