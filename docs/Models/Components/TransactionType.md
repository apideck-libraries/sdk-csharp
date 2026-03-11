# TransactionType

The kind of transaction, indicating whether it is a sales transaction or a purchase transaction.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = TransactionType.Sale;

// Open enum: use .Of() to create instances from custom string values
var custom = TransactionType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Sale`     | sale       |
| `Purchase` | purchase   |