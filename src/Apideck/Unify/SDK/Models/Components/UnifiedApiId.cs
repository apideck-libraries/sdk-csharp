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
    /// Name of Apideck Unified API
    /// </summary>
    public enum UnifiedApiId
    {
        [JsonProperty("accounting")]
        Accounting,
        [JsonProperty("ats")]
        Ats,
        [JsonProperty("calendar")]
        Calendar,
        [JsonProperty("crm")]
        Crm,
        [JsonProperty("csp")]
        Csp,
        [JsonProperty("customer-support")]
        CustomerSupport,
        [JsonProperty("ecommerce")]
        Ecommerce,
        [JsonProperty("email")]
        Email,
        [JsonProperty("email-marketing")]
        EmailMarketing,
        [JsonProperty("expense-management")]
        ExpenseManagement,
        [JsonProperty("file-storage")]
        FileStorage,
        [JsonProperty("form")]
        Form,
        [JsonProperty("hris")]
        Hris,
        [JsonProperty("lead")]
        Lead,
        [JsonProperty("payroll")]
        Payroll,
        [JsonProperty("pos")]
        Pos,
        [JsonProperty("procurement")]
        Procurement,
        [JsonProperty("project-management")]
        ProjectManagement,
        [JsonProperty("script")]
        Script,
        [JsonProperty("sms")]
        Sms,
        [JsonProperty("spreadsheet")]
        Spreadsheet,
        [JsonProperty("team-messaging")]
        TeamMessaging,
        [JsonProperty("issue-tracking")]
        IssueTracking,
        [JsonProperty("time-registration")]
        TimeRegistration,
        [JsonProperty("transactional-email")]
        TransactionalEmail,
        [JsonProperty("vault")]
        Vault,
        [JsonProperty("data-warehouse")]
        DataWarehouse,
    }

    public static class UnifiedApiIdExtension
    {
        public static string Value(this UnifiedApiId value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static UnifiedApiId ToEnum(this string value)
        {
            foreach(var field in typeof(UnifiedApiId).GetFields())
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

                    if (enumVal is UnifiedApiId)
                    {
                        return (UnifiedApiId)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum UnifiedApiId");
        }
    }

}