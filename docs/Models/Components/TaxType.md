# TaxType

The tax applicability of this line item. Overrides the root-level tax_type for this line.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = TaxType.Sales;

// Open enum: use .Of() to create instances from custom string values
var custom = TaxType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Sales`    | sales      |
| `Purchase` | purchase   |