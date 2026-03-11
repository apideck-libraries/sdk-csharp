# CreditNoteType

Type of payment

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