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
    
    public enum WebhookEventType
    {
        [JsonProperty("*")]
        Wildcard,
        [JsonProperty("crm.activity.created")]
        CrmActivityCreated,
        [JsonProperty("crm.activity.updated")]
        CrmActivityUpdated,
        [JsonProperty("crm.activity.deleted")]
        CrmActivityDeleted,
        [JsonProperty("crm.company.created")]
        CrmCompanyCreated,
        [JsonProperty("crm.company.updated")]
        CrmCompanyUpdated,
        [JsonProperty("crm.company.deleted")]
        CrmCompanyDeleted,
        [JsonProperty("crm.contact.created")]
        CrmContactCreated,
        [JsonProperty("crm.contact.updated")]
        CrmContactUpdated,
        [JsonProperty("crm.contact.deleted")]
        CrmContactDeleted,
        [JsonProperty("crm.lead.created")]
        CrmLeadCreated,
        [JsonProperty("crm.lead.updated")]
        CrmLeadUpdated,
        [JsonProperty("crm.lead.deleted")]
        CrmLeadDeleted,
        [JsonProperty("crm.note.created")]
        CrmNoteCreated,
        [JsonProperty("crm.notes.updated")]
        CrmNotesUpdated,
        [JsonProperty("crm.notes.deleted")]
        CrmNotesDeleted,
        [JsonProperty("crm.opportunity.created")]
        CrmOpportunityCreated,
        [JsonProperty("crm.opportunity.updated")]
        CrmOpportunityUpdated,
        [JsonProperty("crm.opportunity.deleted")]
        CrmOpportunityDeleted,
        [JsonProperty("lead.lead.created")]
        LeadLeadCreated,
        [JsonProperty("lead.lead.updated")]
        LeadLeadUpdated,
        [JsonProperty("lead.lead.deleted")]
        LeadLeadDeleted,
        [JsonProperty("vault.connection.created")]
        VaultConnectionCreated,
        [JsonProperty("vault.connection.updated")]
        VaultConnectionUpdated,
        [JsonProperty("vault.connection.disabled")]
        VaultConnectionDisabled,
        [JsonProperty("vault.connection.deleted")]
        VaultConnectionDeleted,
        [JsonProperty("vault.connection.callable")]
        VaultConnectionCallable,
        [JsonProperty("vault.connection.revoked")]
        VaultConnectionRevoked,
        [JsonProperty("vault.connection.token_refresh.failed")]
        VaultConnectionTokenRefreshFailed,
        [JsonProperty("ats.job.created")]
        AtsJobCreated,
        [JsonProperty("ats.job.updated")]
        AtsJobUpdated,
        [JsonProperty("ats.job.deleted")]
        AtsJobDeleted,
        [JsonProperty("ats.applicant.created")]
        AtsApplicantCreated,
        [JsonProperty("ats.applicant.updated")]
        AtsApplicantUpdated,
        [JsonProperty("ats.applicant.deleted")]
        AtsApplicantDeleted,
        [JsonProperty("accounting.customer.created")]
        AccountingCustomerCreated,
        [JsonProperty("accounting.customer.updated")]
        AccountingCustomerUpdated,
        [JsonProperty("accounting.customer.deleted")]
        AccountingCustomerDeleted,
        [JsonProperty("accounting.invoice.created")]
        AccountingInvoiceCreated,
        [JsonProperty("accounting.invoice.updated")]
        AccountingInvoiceUpdated,
        [JsonProperty("accounting.invoice.deleted")]
        AccountingInvoiceDeleted,
        [JsonProperty("accounting.invoice_item.created")]
        AccountingInvoiceItemCreated,
        [JsonProperty("accounting.invoice_item.updated")]
        AccountingInvoiceItemUpdated,
        [JsonProperty("accounting.invoice_item.deleted")]
        AccountingInvoiceItemDeleted,
        [JsonProperty("accounting.ledger_account.created")]
        AccountingLedgerAccountCreated,
        [JsonProperty("accounting.ledger_account.updated")]
        AccountingLedgerAccountUpdated,
        [JsonProperty("accounting.ledger_account.deleted")]
        AccountingLedgerAccountDeleted,
        [JsonProperty("accounting.tax_rate.created")]
        AccountingTaxRateCreated,
        [JsonProperty("accounting.tax_rate.updated")]
        AccountingTaxRateUpdated,
        [JsonProperty("accounting.tax_rate.deleted")]
        AccountingTaxRateDeleted,
        [JsonProperty("accounting.bill.created")]
        AccountingBillCreated,
        [JsonProperty("accounting.bill.updated")]
        AccountingBillUpdated,
        [JsonProperty("accounting.bill.deleted")]
        AccountingBillDeleted,
        [JsonProperty("accounting.payment.created")]
        AccountingPaymentCreated,
        [JsonProperty("accounting.payment.updated")]
        AccountingPaymentUpdated,
        [JsonProperty("accounting.payment.deleted")]
        AccountingPaymentDeleted,
        [JsonProperty("accounting.supplier.created")]
        AccountingSupplierCreated,
        [JsonProperty("accounting.supplier.updated")]
        AccountingSupplierUpdated,
        [JsonProperty("accounting.supplier.deleted")]
        AccountingSupplierDeleted,
        [JsonProperty("accounting.purchase_order.created")]
        AccountingPurchaseOrderCreated,
        [JsonProperty("accounting.purchase_order.updated")]
        AccountingPurchaseOrderUpdated,
        [JsonProperty("accounting.purchase_order.deleted")]
        AccountingPurchaseOrderDeleted,
        [JsonProperty("pos.order.created")]
        PosOrderCreated,
        [JsonProperty("pos.order.updated")]
        PosOrderUpdated,
        [JsonProperty("pos.order.deleted")]
        PosOrderDeleted,
        [JsonProperty("pos.product.created")]
        PosProductCreated,
        [JsonProperty("pos.product.updated")]
        PosProductUpdated,
        [JsonProperty("pos.product.deleted")]
        PosProductDeleted,
        [JsonProperty("pos.payment.created")]
        PosPaymentCreated,
        [JsonProperty("pos.payment.updated")]
        PosPaymentUpdated,
        [JsonProperty("pos.payment.deleted")]
        PosPaymentDeleted,
        [JsonProperty("pos.merchant.created")]
        PosMerchantCreated,
        [JsonProperty("pos.merchant.updated")]
        PosMerchantUpdated,
        [JsonProperty("pos.merchant.deleted")]
        PosMerchantDeleted,
        [JsonProperty("pos.location.created")]
        PosLocationCreated,
        [JsonProperty("pos.location.updated")]
        PosLocationUpdated,
        [JsonProperty("pos.location.deleted")]
        PosLocationDeleted,
        [JsonProperty("pos.item.created")]
        PosItemCreated,
        [JsonProperty("pos.item.updated")]
        PosItemUpdated,
        [JsonProperty("pos.item.deleted")]
        PosItemDeleted,
        [JsonProperty("pos.modifier.created")]
        PosModifierCreated,
        [JsonProperty("pos.modifier.updated")]
        PosModifierUpdated,
        [JsonProperty("pos.modifier.deleted")]
        PosModifierDeleted,
        [JsonProperty("pos.modifier-group.created")]
        PosModifierGroupCreated,
        [JsonProperty("pos.modifier-group.updated")]
        PosModifierGroupUpdated,
        [JsonProperty("pos.modifier-group.deleted")]
        PosModifierGroupDeleted,
        [JsonProperty("hris.employee.created")]
        HrisEmployeeCreated,
        [JsonProperty("hris.employee.updated")]
        HrisEmployeeUpdated,
        [JsonProperty("hris.employee.deleted")]
        HrisEmployeeDeleted,
        [JsonProperty("hris.employee.terminated")]
        HrisEmployeeTerminated,
        [JsonProperty("hris.company.created")]
        HrisCompanyCreated,
        [JsonProperty("hris.company.updated")]
        HrisCompanyUpdated,
        [JsonProperty("hris.company.deleted")]
        HrisCompanyDeleted,
        [JsonProperty("file-storage.file.created")]
        FileStorageFileCreated,
        [JsonProperty("file-storage.file.updated")]
        FileStorageFileUpdated,
        [JsonProperty("file-storage.file.deleted")]
        FileStorageFileDeleted,
        [JsonProperty("issue-tracking.ticket.created")]
        IssueTrackingTicketCreated,
        [JsonProperty("issue-tracking.ticket.updated")]
        IssueTrackingTicketUpdated,
        [JsonProperty("issue-tracking.ticket.deleted")]
        IssueTrackingTicketDeleted,
        [JsonProperty("ats.application.created")]
        AtsApplicationCreated,
        [JsonProperty("ats.application.updated")]
        AtsApplicationUpdated,
        [JsonProperty("ats.application.deleted")]
        AtsApplicationDeleted,
        [JsonProperty("accounting.expense.created")]
        AccountingExpenseCreated,
        [JsonProperty("accounting.expense.updated")]
        AccountingExpenseUpdated,
        [JsonProperty("accounting.expense.deleted")]
        AccountingExpenseDeleted,
    }

    public static class WebhookEventTypeExtension
    {
        public static string Value(this WebhookEventType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static WebhookEventType ToEnum(this string value)
        {
            foreach(var field in typeof(WebhookEventType).GetFields())
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

                    if (enumVal is WebhookEventType)
                    {
                        return (WebhookEventType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum WebhookEventType");
        }
    }

}