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
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class Data
    {

        [JsonProperty("consumer_id")]
        public string? ConsumerId { get; set; }

        [JsonProperty("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// The metadata of the consumer. This is used to display the consumer in the sidebar. This is optional, but recommended.
        /// </summary>
        [JsonProperty("metadata")]
        public ConsumerMetadata? Metadata { get; set; }

        [JsonProperty("aggregated_request_count")]
        public double? AggregatedRequestCount { get; set; }

        [JsonProperty("request_counts")]
        public RequestCountAllocation? RequestCounts { get; set; }

        [JsonProperty("created")]
        public string? Created { get; set; }

        [JsonProperty("modified")]
        public string? Modified { get; set; }

        [JsonProperty("request_count_updated")]
        public string? RequestCountUpdated { get; set; }

        [JsonProperty("services")]
        public List<string>? Services { get; set; }
    }
}