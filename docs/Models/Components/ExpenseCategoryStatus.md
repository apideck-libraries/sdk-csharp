# ExpenseCategoryStatus

The status of the expense category.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ExpenseCategoryStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = ExpenseCategoryStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |