# LocationStatus

Based on the status some functionality is enabled or disabled.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = LocationStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = LocationStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |