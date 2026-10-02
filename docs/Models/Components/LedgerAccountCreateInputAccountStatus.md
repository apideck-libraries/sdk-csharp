# LedgerAccountCreateInputAccountStatus

The status of the account.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = LedgerAccountCreateInputAccountStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = LedgerAccountCreateInputAccountStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |
| `Archived` | archived   |