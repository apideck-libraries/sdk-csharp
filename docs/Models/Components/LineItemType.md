# LineItemType

Line Item type

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = LineItemType.ExpenseItem;

// Open enum: use .Of() to create instances from custom string values
var custom = LineItemType.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `ExpenseItem`    | expense_item     |
| `ExpenseAccount` | expense_account  |
| `Other`          | other            |