# LedgerAccountClassification

The classification of account.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = LedgerAccountClassification.Asset;

// Open enum: use .Of() to create instances from custom string values
var custom = LedgerAccountClassification.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Asset`        | asset          |
| `Equity`       | equity         |
| `Expense`      | expense        |
| `Liability`    | liability      |
| `Revenue`      | revenue        |
| `Income`       | income         |
| `OtherIncome`  | other_income   |
| `OtherExpense` | other_expense  |
| `CostsOfSales` | costs_of_sales |
| `Other`        | other          |