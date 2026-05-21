# LedgerAccountsFilterStatus

Filter by account status.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = LedgerAccountsFilterStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = LedgerAccountsFilterStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |