//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace ApideckUnifySdk
{
    using ApideckUnifySdk.Models.Components;
    using ApideckUnifySdk.Models.Errors;
    using ApideckUnifySdk.Utils;
    using System;

    public interface IAccounting
    {
        public ITaxRates TaxRates { get; }
        public IBills Bills { get; }
        public IInvoices Invoices { get; }
        public ILedgerAccounts LedgerAccounts { get; }
        public IInvoiceItems InvoiceItems { get; }
        public ICreditNotes CreditNotes { get; }
        public ICustomers Customers { get; }
        public ISuppliers Suppliers { get; }
        public IPayments Payments { get; }
        public ICompanyInfo CompanyInfo { get; }
        public IBalanceSheet BalanceSheet { get; }
        public IProfitAndLoss ProfitAndLoss { get; }
        public IJournalEntries JournalEntries { get; }
        public IPurchaseOrders PurchaseOrders { get; }
        public ISubsidiaries Subsidiaries { get; }
        public ILocations Locations { get; }
        public IDepartments Departments { get; }
        public IAttachments Attachments { get; }
        public ITrackingCategories TrackingCategories { get; }
        public IBillPayments BillPayments { get; }
        public IExpenses Expenses { get; }
        public IAgedDebtors AgedDebtors { get; }
    }

    public class Accounting: IAccounting
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.4.1";
        private const string _sdkGenVersion = "2.493.34";
        private const string _openapiDocVersion = "10.10.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.4.1 2.493.34 10.10.0 ApideckUnifySdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<ApideckUnifySdk.Models.Components.Security>? _securitySource;
        public ITaxRates TaxRates { get; private set; }
        public IBills Bills { get; private set; }
        public IInvoices Invoices { get; private set; }
        public ILedgerAccounts LedgerAccounts { get; private set; }
        public IInvoiceItems InvoiceItems { get; private set; }
        public ICreditNotes CreditNotes { get; private set; }
        public ICustomers Customers { get; private set; }
        public ISuppliers Suppliers { get; private set; }
        public IPayments Payments { get; private set; }
        public ICompanyInfo CompanyInfo { get; private set; }
        public IBalanceSheet BalanceSheet { get; private set; }
        public IProfitAndLoss ProfitAndLoss { get; private set; }
        public IJournalEntries JournalEntries { get; private set; }
        public IPurchaseOrders PurchaseOrders { get; private set; }
        public ISubsidiaries Subsidiaries { get; private set; }
        public ILocations Locations { get; private set; }
        public IDepartments Departments { get; private set; }
        public IAttachments Attachments { get; private set; }
        public ITrackingCategories TrackingCategories { get; private set; }
        public IBillPayments BillPayments { get; private set; }
        public IExpenses Expenses { get; private set; }
        public IAgedDebtors AgedDebtors { get; private set; }

        public Accounting(ISpeakeasyHttpClient client, Func<ApideckUnifySdk.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            TaxRates = new TaxRates(_client, _securitySource, _serverUrl, SDKConfiguration);
            Bills = new Bills(_client, _securitySource, _serverUrl, SDKConfiguration);
            Invoices = new Invoices(_client, _securitySource, _serverUrl, SDKConfiguration);
            LedgerAccounts = new LedgerAccounts(_client, _securitySource, _serverUrl, SDKConfiguration);
            InvoiceItems = new InvoiceItems(_client, _securitySource, _serverUrl, SDKConfiguration);
            CreditNotes = new CreditNotes(_client, _securitySource, _serverUrl, SDKConfiguration);
            Customers = new Customers(_client, _securitySource, _serverUrl, SDKConfiguration);
            Suppliers = new Suppliers(_client, _securitySource, _serverUrl, SDKConfiguration);
            Payments = new Payments(_client, _securitySource, _serverUrl, SDKConfiguration);
            CompanyInfo = new CompanyInfo(_client, _securitySource, _serverUrl, SDKConfiguration);
            BalanceSheet = new BalanceSheet(_client, _securitySource, _serverUrl, SDKConfiguration);
            ProfitAndLoss = new ProfitAndLoss(_client, _securitySource, _serverUrl, SDKConfiguration);
            JournalEntries = new JournalEntries(_client, _securitySource, _serverUrl, SDKConfiguration);
            PurchaseOrders = new PurchaseOrders(_client, _securitySource, _serverUrl, SDKConfiguration);
            Subsidiaries = new Subsidiaries(_client, _securitySource, _serverUrl, SDKConfiguration);
            Locations = new Locations(_client, _securitySource, _serverUrl, SDKConfiguration);
            Departments = new Departments(_client, _securitySource, _serverUrl, SDKConfiguration);
            Attachments = new Attachments(_client, _securitySource, _serverUrl, SDKConfiguration);
            TrackingCategories = new TrackingCategories(_client, _securitySource, _serverUrl, SDKConfiguration);
            BillPayments = new BillPayments(_client, _securitySource, _serverUrl, SDKConfiguration);
            Expenses = new Expenses(_client, _securitySource, _serverUrl, SDKConfiguration);
            AgedDebtors = new AgedDebtors(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}