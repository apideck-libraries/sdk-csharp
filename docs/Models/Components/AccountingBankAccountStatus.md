# AccountingBankAccountStatus

The status of the bank account

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = AccountingBankAccountStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingBankAccountStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |
| `Closed`   | closed     |