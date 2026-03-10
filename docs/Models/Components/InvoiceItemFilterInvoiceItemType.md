# InvoiceItemFilterInvoiceItemType

The type of invoice item, indicating whether it is an inventory item, a service, or another type.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = InvoiceItemFilterInvoiceItemType.Inventory;

// Open enum: use .Of() to create instances from custom string values
var custom = InvoiceItemFilterInvoiceItemType.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Inventory` | inventory   |
| `Service`   | service     |
| `Other`     | other       |