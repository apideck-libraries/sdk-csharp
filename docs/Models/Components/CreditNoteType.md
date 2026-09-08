# CreditNoteType

Whether this credit note reduces an amount owed by a customer (accounts receivable) or owed to a supplier (accounts payable). `accounts_payable_credit` support is connector-specific — most connectors only expose the accounts-receivable side. Check the connector's gotchas for known deviations.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = CreditNoteType.AccountsReceivableCredit;

// Open enum: use .Of() to create instances from custom string values
var custom = CreditNoteType.Of("custom_value");
```


## Values

| Name                       | Value                      |
| -------------------------- | -------------------------- |
| `AccountsReceivableCredit` | accounts_receivable_credit |
| `AccountsPayableCredit`    | accounts_payable_credit    |