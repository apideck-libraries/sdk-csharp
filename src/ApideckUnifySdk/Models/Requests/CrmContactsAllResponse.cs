//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace ApideckUnifySdk.Models.Requests
{
    using ApideckUnifySdk.Models.Components;
    using ApideckUnifySdk.Utils;
    using Newtonsoft.Json;
    using System.Threading.Tasks;
    using System;
    
    public class CrmContactsAllResponse
    {
        public Func<Task<CrmContactsAllResponse?>>? Next {get;set;}

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;

        /// <summary>
        /// Contacts
        /// </summary>
        public GetContactsResponse? GetContactsResponse { get; set; }

        /// <summary>
        /// Unexpected error
        /// </summary>
        public UnexpectedErrorResponse? UnexpectedErrorResponse { get; set; }
    }
}