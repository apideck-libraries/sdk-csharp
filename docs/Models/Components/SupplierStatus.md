# SupplierStatus

Supplier status

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = SupplierStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = SupplierStatus.Of("custom_value");
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `Active`             | active               |
| `Inactive`           | inactive             |
| `Archived`           | archived             |
| `GdprErasureRequest` | gdpr-erasure-request |
| `Unknown`            | unknown              |