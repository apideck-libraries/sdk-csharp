# CompanyStatus

Based on the status some functionality is enabled or disabled.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = CompanyStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = CompanyStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |