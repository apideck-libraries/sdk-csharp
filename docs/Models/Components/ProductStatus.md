# ProductStatus

The current status of the product (active or archived).

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ProductStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = ProductStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Archived` | archived   |