# InvoiceType

Invoice type

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = InvoiceType.Standard;

// Open enum: use .Of() to create instances from custom string values
var custom = InvoiceType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Standard` | standard   |
| `Credit`   | credit     |
| `Service`  | service    |
| `Product`  | product    |
| `Supplier` | supplier   |
| `Other`    | other      |