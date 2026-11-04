# ExpenseUpdateInputStatus

Expense status

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ExpenseUpdateInputStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = ExpenseUpdateInputStatus.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Draft`  | draft    |
| `Posted` | posted   |
| `Voided` | voided   |