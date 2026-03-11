# InvoiceItemType

The type of invoice item, indicating whether it is an inventory item, a service, or another type.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = InvoiceItemType.Inventory;

// Open enum: use .Of() to create instances from custom string values
var custom = InvoiceItemType.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Inventory` | inventory   |
| `Service`   | service     |
| `Other`     | other       |