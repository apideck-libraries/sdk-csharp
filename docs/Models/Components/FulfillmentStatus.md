# FulfillmentStatus

Current fulfillment status of the order.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = FulfillmentStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = FulfillmentStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Pending`   | pending     |
| `Shipped`   | shipped     |
| `Partial`   | partial     |
| `Delivered` | delivered   |
| `Cancelled` | cancelled   |
| `Returned`  | returned    |
| `Unknown`   | unknown     |