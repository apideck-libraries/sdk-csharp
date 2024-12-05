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
    /// Status of payment
    /// </summary>
    public enum PaymentStatus
    {
        [JsonProperty("authorised")]
        Authorised,
        [JsonProperty("paid")]
        Paid,
        [JsonProperty("voided")]
        Voided,
        [JsonProperty("deleted")]
        Deleted,
    }

    public static class PaymentStatusExtension
    {
        public static string Value(this PaymentStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PaymentStatus ToEnum(this string value)
        {
            foreach(var field in typeof(PaymentStatus).GetFields())
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

                    if (enumVal is PaymentStatus)
                    {
                        return (PaymentStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PaymentStatus");
        }
    }

}