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
    
    public class TicketsSort
    {

        /// <summary>
        /// The field on which to sort the Tickets
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=by")]
        public TicketsSortBy? By { get; set; }

        /// <summary>
        /// The direction in which to sort the results
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=direction")]
        public SortDirection? Direction { get; set; } = ApideckUnifySdk.Models.Components.SortDirection.Asc;
    }
}