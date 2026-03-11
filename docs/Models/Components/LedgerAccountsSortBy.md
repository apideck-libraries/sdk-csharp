# LedgerAccountsSortBy

The field on which to sort the Ledger Accounts

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = LedgerAccountsSortBy.CreatedAt;

// Open enum: use .Of() to create instances from custom string values
var custom = LedgerAccountsSortBy.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `CreatedAt` | created_at  |
| `UpdatedAt` | updated_at  |