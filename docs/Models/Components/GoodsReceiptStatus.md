# GoodsReceiptStatus

Lifecycle status of the receipt. `draft` covers unposted or awaiting-validation documents, `pending_approval` covers documents submitted into an approval flow, `received` covers posted/validated/released receipts that have affected stock or the receiving ledger, `cancelled` covers voided, reversed or denied receipts.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = GoodsReceiptStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = GoodsReceiptStatus.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `Draft`           | draft             |
| `PendingApproval` | pending_approval  |
| `Received`        | received          |
| `Cancelled`       | cancelled         |
| `Other`           | other             |