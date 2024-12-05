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
    
    /// <summary>
    /// The overview of the payroll totals.
    /// </summary>
    public class PayrollTotals
    {

        /// <summary>
        /// The total company debit for the payroll.
        /// </summary>
        [JsonProperty("company_debit")]
        public double? CompanyDebit { get; set; } = null;

        /// <summary>
        /// The total tax debit for the payroll.
        /// </summary>
        [JsonProperty("tax_debit")]
        public double? TaxDebit { get; set; } = null;

        /// <summary>
        /// The total check amount for the payroll.
        /// </summary>
        [JsonProperty("check_amount")]
        public double? CheckAmount { get; set; } = null;

        /// <summary>
        /// The net pay amount for the payroll.
        /// </summary>
        [JsonProperty("net_pay")]
        public double? NetPay { get; set; } = null;

        /// <summary>
        /// The gross pay amount for the payroll.
        /// </summary>
        [JsonProperty("gross_pay")]
        public double? GrossPay { get; set; } = null;

        /// <summary>
        /// The total amount of employer paid taxes for the payroll.
        /// </summary>
        [JsonProperty("employer_taxes")]
        public double? EmployerTaxes { get; set; } = null;

        /// <summary>
        /// The total amount of employee paid taxes for the payroll.
        /// </summary>
        [JsonProperty("employee_taxes")]
        public double? EmployeeTaxes { get; set; } = null;

        /// <summary>
        /// The total amount of company contributed benefits for the payroll.
        /// </summary>
        [JsonProperty("employer_benefit_contributions")]
        public double? EmployerBenefitContributions { get; set; } = null;

        /// <summary>
        /// The total amount of employee deducted benefits for the payroll.
        /// </summary>
        [JsonProperty("employee_benefit_deductions")]
        public double? EmployeeBenefitDeductions { get; set; } = null;
    }
}