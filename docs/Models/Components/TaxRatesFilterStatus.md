# TaxRatesFilterStatus

Filter by tax rate status

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = TaxRatesFilterStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = TaxRatesFilterStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |
| `Archived` | archived   |