# BillPaymentAllocationType

Type of entity this payment should be attributed to.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BillPaymentAllocationType.Bill;

// Open enum: use .Of() to create instances from custom string values
var custom = BillPaymentAllocationType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Bill`         | bill           |
| `Expense`      | expense        |
| `CreditMemo`   | credit_memo    |
| `OverPayment`  | over_payment   |
| `PrePayment`   | pre_payment    |
| `JournalEntry` | journal_entry  |
| `Other`        | other          |