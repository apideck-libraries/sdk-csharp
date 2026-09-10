# JournalType

Normalized journal classification.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = JournalType.General;

// Open enum: use .Of() to create instances from custom string values
var custom = JournalType.Of("custom_value");
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `General`            | general              |
| `Sales`              | sales                |
| `Purchase`           | purchase             |
| `SalesCreditNote`    | sales_credit_note    |
| `PurchaseCreditNote` | purchase_credit_note |
| `Cash`               | cash                 |
| `Bank`               | bank                 |
| `PaymentService`     | payment_service      |
| `Other`              | other                |