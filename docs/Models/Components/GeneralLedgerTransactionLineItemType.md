# GeneralLedgerTransactionLineItemType

Side of the entry. Redundant with the sign of net_amount but exposed as an explicit flag for filtering convenience.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = GeneralLedgerTransactionLineItemType.Debit;

// Open enum: use .Of() to create instances from custom string values
var custom = GeneralLedgerTransactionLineItemType.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Debit`  | debit    |
| `Credit` | credit   |