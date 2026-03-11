# InvoiceLineItemType

Item type

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = InvoiceLineItemType.SalesItem;

// Open enum: use .Of() to create instances from custom string values
var custom = InvoiceLineItemType.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `SalesItem` | sales_item  |
| `Discount`  | discount    |
| `Info`      | info        |
| `SubTotal`  | sub_total   |
| `Service`   | service     |
| `Other`     | other       |