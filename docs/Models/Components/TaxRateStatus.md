# TaxRateStatus

Tax rate status

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = TaxRateStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = TaxRateStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |
| `Archived` | archived   |