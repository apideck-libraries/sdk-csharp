# BillStatus

Invoice status

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BillStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = BillStatus.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Draft`         | draft           |
| `Submitted`     | submitted       |
| `Authorised`    | authorised      |
| `PartiallyPaid` | partially_paid  |
| `Paid`          | paid            |
| `Void`          | void            |
| `Credit`        | credit          |
| `Deleted`       | deleted         |
| `Posted`        | posted          |