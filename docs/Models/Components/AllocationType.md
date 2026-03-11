# AllocationType

Type of entity this payment should be attributed to.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = AllocationType.Invoice;

// Open enum: use .Of() to create instances from custom string values
var custom = AllocationType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Invoice`      | invoice        |
| `Order`        | order          |
| `Expense`      | expense        |
| `CreditMemo`   | credit_memo    |
| `OverPayment`  | over_payment   |
| `PrePayment`   | pre_payment    |
| `JournalEntry` | journal_entry  |
| `Other`        | other          |
| `Bill`         | bill           |