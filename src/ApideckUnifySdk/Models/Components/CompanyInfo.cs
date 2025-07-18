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
    using NodaTime;
    using System;
    using System.Collections.Generic;
    
    public class CompanyInfo
    {

        /// <summary>
        /// A unique identifier for an object.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the company.
        /// </summary>
        [JsonProperty("company_name")]
        public string? CompanyName { get; set; } = null;

        /// <summary>
        /// Based on the status some functionality is enabled or disabled.
        /// </summary>
        [JsonProperty("status")]
        public CompanyStatus? Status { get; set; }

        /// <summary>
        /// The legal name of the company
        /// </summary>
        [JsonProperty("legal_name")]
        public string? LegalName { get; set; }

        /// <summary>
        /// country code according to ISO 3166-1 alpha-2.
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; } = null;

        [JsonProperty("sales_tax_number")]
        public string? SalesTaxNumber { get; set; } = null;

        /// <summary>
        /// Whether sales tax is calculated automatically for the company
        /// </summary>
        [JsonProperty("automated_sales_tax")]
        public bool? AutomatedSalesTax { get; set; }

        /// <summary>
        /// Whether sales tax is enabled for the company
        /// </summary>
        [JsonProperty("sales_tax_enabled")]
        public bool? SalesTaxEnabled { get; set; }

        [JsonProperty("default_sales_tax")]
        public TaxRate? DefaultSalesTax { get; set; }

        /// <summary>
        /// Indicates the associated currency for an amount of money. Values correspond to <a href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217</a>.
        /// </summary>
        [JsonProperty("currency")]
        public Currency? Currency { get; set; } = null;

        /// <summary>
        /// language code according to ISO 639-1. For the United States - EN
        /// </summary>
        [JsonProperty("language")]
        public string? Language { get; set; } = null;

        /// <summary>
        /// The start month of fiscal year.
        /// </summary>
        [JsonProperty("fiscal_year_start_month")]
        public TheStartMonthOfFiscalYear? FiscalYearStartMonth { get; set; }

        /// <summary>
        /// Date when company file was created
        /// </summary>
        [JsonProperty("company_start_date")]
        public LocalDate? CompanyStartDate { get; set; }

        [JsonProperty("addresses")]
        public List<Address>? Addresses { get; set; }

        [JsonProperty("phone_numbers")]
        public List<PhoneNumber>? PhoneNumbers { get; set; }

        [JsonProperty("emails")]
        public List<Email>? Emails { get; set; }

        /// <summary>
        /// When custom mappings are configured on the resource, the result is included here.
        /// </summary>
        [JsonProperty("custom_mappings")]
        public Dictionary<string, object>? CustomMappings { get; set; } = null;

        /// <summary>
        /// Whether tracking categories are enabled for the company on transactions
        /// </summary>
        [JsonProperty("tracking_categories_enabled")]
        public bool? TrackingCategoriesEnabled { get; set; }

        /// <summary>
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        [JsonProperty("row_version")]
        public string? RowVersion { get; set; } = null;

        /// <summary>
        /// The user who last updated the object.
        /// </summary>
        [JsonProperty("updated_by")]
        public string? UpdatedBy { get; set; } = null;

        /// <summary>
        /// The user who created the object.
        /// </summary>
        [JsonProperty("created_by")]
        public string? CreatedBy { get; set; } = null;

        /// <summary>
        /// The date and time when the object was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;
    }
}