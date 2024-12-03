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
    using Newtonsoft.Json;
    using System;
    using Unify.Utils;
    
    public enum AttachmentReferenceType
    {
        [JsonProperty("invoice")]
        Invoice,
        [JsonProperty("bill")]
        Bill,
        [JsonProperty("expense")]
        Expense,
    }

    public static class AttachmentReferenceTypeExtension
    {
        public static string Value(this AttachmentReferenceType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AttachmentReferenceType ToEnum(this string value)
        {
            foreach(var field in typeof(AttachmentReferenceType).GetFields())
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

                    if (enumVal is AttachmentReferenceType)
                    {
                        return (AttachmentReferenceType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum AttachmentReferenceType");
        }
    }

}