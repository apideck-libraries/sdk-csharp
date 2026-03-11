# ExpenseReportsFilterStatus

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ExpenseReportsFilterStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = ExpenseReportsFilterStatus.Of("custom_value");
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