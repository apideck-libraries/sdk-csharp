# ExpenseReportStatus

The status of the expense report.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ExpenseReportStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = ExpenseReportStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Draft`      | draft        |
| `Submitted`  | submitted    |
| `Approved`   | approved     |
| `Reimbursed` | reimbursed   |
| `Rejected`   | rejected     |
| `Reversed`   | reversed     |
| `Voided`     | voided       |