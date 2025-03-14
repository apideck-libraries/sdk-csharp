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
    using ApideckUnifySdk.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The type of profit and loss
    /// </summary>
    public enum ProfitAndLossType
    {
        [JsonProperty("Section")]
        Section,
        [JsonProperty("Record")]
        Record,
    }

    public static class ProfitAndLossTypeExtension
    {
        public static string Value(this ProfitAndLossType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ProfitAndLossType ToEnum(this string value)
        {
            foreach(var field in typeof(ProfitAndLossType).GetFields())
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

                    if (enumVal is ProfitAndLossType)
                    {
                        return (ProfitAndLossType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ProfitAndLossType");
        }
    }

}