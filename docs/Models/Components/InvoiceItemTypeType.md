# InvoiceItemTypeType

Item type

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = InvoiceItemTypeType.Inventory;

// Open enum: use .Of() to create instances from custom string values
var custom = InvoiceItemTypeType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Inventory`    | inventory      |
| `NonInventory` | non_inventory  |
| `Service`      | service        |
| `Description`  | description    |
| `Other`        | other          |