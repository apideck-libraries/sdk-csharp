# EcommerceOrderStatus

Current status of the order.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = EcommerceOrderStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = EcommerceOrderStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Active`    | active      |
| `Completed` | completed   |
| `Cancelled` | cancelled   |
| `Archived`  | archived    |
| `Unknown`   | unknown     |
| `Other`     | other       |