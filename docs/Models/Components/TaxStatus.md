# TaxStatus

The tax applicability of the product: `taxable` (the product is taxed), `shipping` (only the shipping is taxed, the product itself is exempt) or `none` (neither is taxed).

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = TaxStatus.Taxable;

// Open enum: use .Of() to create instances from custom string values
var custom = TaxStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Taxable`  | taxable    |
| `Shipping` | shipping   |
| `None`     | none       |