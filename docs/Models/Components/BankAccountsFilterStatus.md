# BankAccountsFilterStatus

Filter by account status

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BankAccountsFilterStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = BankAccountsFilterStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |
| `Closed`   | closed     |