# ExpenseUpdateInputExpenseType

The type of expense.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ExpenseUpdateInputExpenseType.Expense;

// Open enum: use .Of() to create instances from custom string values
var custom = ExpenseUpdateInputExpenseType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Expense` | expense   |
| `Refund`  | refund    |