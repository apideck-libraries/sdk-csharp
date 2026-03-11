# BillsFilterStatus

Filter by bill status

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BillsFilterStatus.Paid;

// Open enum: use .Of() to create instances from custom string values
var custom = BillsFilterStatus.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Paid`          | paid            |
| `Unpaid`        | unpaid          |
| `PartiallyPaid` | partially_paid  |