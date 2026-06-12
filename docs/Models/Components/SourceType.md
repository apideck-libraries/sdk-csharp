# SourceType

Filter by the originating transaction type.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = SourceType.Other;

// Open enum: use .Of() to create instances from custom string values
var custom = SourceType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Other`        | other          |
| `Invoice`      | invoice        |
| `Bill`         | bill           |
| `CreditNote`   | credit_note    |
| `Payment`      | payment        |
| `Refund`       | refund         |
| `Expense`      | expense        |
| `JournalEntry` | journal_entry  |
| `Payroll`      | payroll        |