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
    
    public enum FormFieldType
    {
        [JsonProperty("text")]
        Text,
        [JsonProperty("checkbox")]
        Checkbox,
        [JsonProperty("tel")]
        Tel,
        [JsonProperty("email")]
        Email,
        [JsonProperty("url")]
        Url,
        [JsonProperty("textarea")]
        Textarea,
        [JsonProperty("select")]
        Select,
        [JsonProperty("filtered-select")]
        FilteredSelect,
        [JsonProperty("multi-select")]
        MultiSelect,
        [JsonProperty("datetime")]
        Datetime,
        [JsonProperty("date")]
        Date,
        [JsonProperty("time")]
        Time,
        [JsonProperty("number")]
        Number,
    }

    public static class FormFieldTypeExtension
    {
        public static string Value(this FormFieldType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static FormFieldType ToEnum(this string value)
        {
            foreach(var field in typeof(FormFieldType).GetFields())
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

                    if (enumVal is FormFieldType)
                    {
                        return (FormFieldType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum FormFieldType");
        }
    }

}