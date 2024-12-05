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
    using Apideck.Unify.SDK.Models.Components;
    using Apideck.Unify.SDK.Utils;
    
    public class PurchaseOrdersSort
    {

        /// <summary>
        /// The field on which to sort the Purchase Orders
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=by")]
        public PurchaseOrdersSortBy? By { get; set; }

        /// <summary>
        /// The direction in which to sort the results
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=direction")]
        public SortDirection? Direction { get; set; } = Apideck.Unify.SDK.Models.Components.SortDirection.Asc;
    }
}