# ExpenseType

The type of expense.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ExpenseType.Expense;

// Open enum: use .Of() to create instances from custom string values
var custom = ExpenseType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Expense` | expense   |
| `Refund`  | refund    |