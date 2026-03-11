# HrisCompanyStatus

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = HrisCompanyStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisCompanyStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |
| `Trial`    | trial      |
| `Other`    | other      |