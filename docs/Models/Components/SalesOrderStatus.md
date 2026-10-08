# SalesOrderStatus

Sales order status, in order of precedence: `cancelled`; `closed` (the order is closed or completed, whether or not it was billed); `invoiced` (fully billed but not yet closed); `back_ordered`; `on_hold` (including credit hold); `draft` (including pending approval); `open` (every other active state, including partially shipped and partially invoiced); `other` for states that fit none of these.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = SalesOrderStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = SalesOrderStatus.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Draft`       | draft         |
| `Open`        | open          |
| `OnHold`      | on_hold       |
| `BackOrdered` | back_ordered  |
| `Invoiced`    | invoiced      |
| `Closed`      | closed        |
| `Cancelled`   | cancelled     |
| `Other`       | other         |