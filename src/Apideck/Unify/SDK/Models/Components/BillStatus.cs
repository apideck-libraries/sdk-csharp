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
    using System;
    
    /// <summary>
    /// Invoice status
    /// </summary>
    public enum BillStatus
    {
        [JsonProperty("draft")]
        Draft,
        [JsonProperty("submitted")]
        Submitted,
        [JsonProperty("authorised")]
        Authorised,
        [JsonProperty("partially_paid")]
        PartiallyPaid,
        [JsonProperty("paid")]
        Paid,
        [JsonProperty("void")]
        Void,
        [JsonProperty("credit")]
        Credit,
        [JsonProperty("deleted")]
        Deleted,
    }

    public static class BillStatusExtension
    {
        public static string Value(this BillStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static BillStatus ToEnum(this string value)
        {
            foreach(var field in typeof(BillStatus).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is BillStatus)
                    {
                        return (BillStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum BillStatus");
        }
    }

}