# StatementStatus

The current status of the bank feed statement.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = StatementStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = StatementStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Pending`  | pending    |
| `Rejected` | rejected   |
| `Success`  | success    |