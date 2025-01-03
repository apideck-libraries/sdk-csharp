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
    /// The type of account.
    /// </summary>
    public enum LedgerAccountType
    {
        [JsonProperty("accounts_receivable")]
        AccountsReceivable,
        [JsonProperty("revenue")]
        Revenue,
        [JsonProperty("sales")]
        Sales,
        [JsonProperty("other_income")]
        OtherIncome,
        [JsonProperty("bank")]
        Bank,
        [JsonProperty("current_asset")]
        CurrentAsset,
        [JsonProperty("fixed_asset")]
        FixedAsset,
        [JsonProperty("non_current_asset")]
        NonCurrentAsset,
        [JsonProperty("other_asset")]
        OtherAsset,
        [JsonProperty("balancesheet")]
        Balancesheet,
        [JsonProperty("equity")]
        Equity,
        [JsonProperty("expense")]
        Expense,
        [JsonProperty("other_expense")]
        OtherExpense,
        [JsonProperty("costs_of_sales")]
        CostsOfSales,
        [JsonProperty("accounts_payable")]
        AccountsPayable,
        [JsonProperty("credit_card")]
        CreditCard,
        [JsonProperty("current_liability")]
        CurrentLiability,
        [JsonProperty("non_current_liability")]
        NonCurrentLiability,
        [JsonProperty("other_liability")]
        OtherLiability,
        [JsonProperty("other")]
        Other,
    }

    public static class LedgerAccountTypeExtension
    {
        public static string Value(this LedgerAccountType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static LedgerAccountType ToEnum(this string value)
        {
            foreach(var field in typeof(LedgerAccountType).GetFields())
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

                    if (enumVal is LedgerAccountType)
                    {
                        return (LedgerAccountType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum LedgerAccountType");
        }
    }

}