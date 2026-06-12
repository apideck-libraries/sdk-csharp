# GeneralLedgerTransactionsSortBy

The field on which to sort the General Ledger Transactions.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = GeneralLedgerTransactionsSortBy.PostedAt;

// Open enum: use .Of() to create instances from custom string values
var custom = GeneralLedgerTransactionsSortBy.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `PostedAt`  | posted_at   |
| `UpdatedAt` | updated_at  |
| `CreatedAt` | created_at  |