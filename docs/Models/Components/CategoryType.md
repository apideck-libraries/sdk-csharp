# CategoryType

The type of the category.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = CategoryType.Supplier;

// Open enum: use .Of() to create instances from custom string values
var custom = CategoryType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Supplier` | supplier   |
| `Expense`  | expense    |
| `Revenue`  | revenue    |
| `Customer` | customer   |