# CustomerStatusStatus

Customer status

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = CustomerStatusStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = CustomerStatusStatus.Of("custom_value");
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `Active`             | active               |
| `Inactive`           | inactive             |
| `Archived`           | archived             |
| `GdprErasureRequest` | gdpr-erasure-request |
| `Unknown`            | unknown              |