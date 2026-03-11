# Classification

Filter by account classification.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = Classification.Asset;

// Open enum: use .Of() to create instances from custom string values
var custom = Classification.Of("custom_value");
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