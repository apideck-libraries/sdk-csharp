# PurchaseOrderStatus

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = PurchaseOrderStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = PurchaseOrderStatus.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Draft`   | draft     |
| `Open`    | open      |
| `Closed`  | closed    |
| `Deleted` | deleted   |
| `Billed`  | billed    |
| `Other`   | other     |