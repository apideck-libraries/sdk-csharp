# RefundType

Type of refund. `refund_receipt` for itemized refunds with product/service lines and payment (QBO RefundReceipt, NetSuite CashRefund). `cash_refund` for cash-out refunds with GL distribution or allocations (Sage Intacct). `credit_note_refund` for refunds applied against a credit note (Zoho Books).

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = RefundType.RefundReceipt;

// Open enum: use .Of() to create instances from custom string values
var custom = RefundType.Of("custom_value");
```


## Values

| Name               | Value              |
| ------------------ | ------------------ |
| `RefundReceipt`    | refund_receipt     |
| `CashRefund`       | cash_refund        |
| `CreditNoteRefund` | credit_note_refund |