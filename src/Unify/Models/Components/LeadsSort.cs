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
    using Unify.Models.Components;
    using Unify.Utils;
    
    public class LeadsSort
    {

        /// <summary>
        /// The field on which to sort the Leads
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=by")]
        public LeadsSortBy? By { get; set; }

        /// <summary>
        /// The direction in which to sort the results
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=direction")]
        public SortDirection? Direction { get; set; } = Unify.Models.Components.SortDirection.Asc;
    }
}