# BillCreditNoteType

The type of credit note. A bill credit note is always an accounts payable (supplier-side) credit.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BillCreditNoteType.AccountsPayableCredit;

// Open enum: use .Of() to create instances from custom string values
var custom = BillCreditNoteType.Of("custom_value");
```


## Values

| Name                    | Value                   |
| ----------------------- | ----------------------- |
| `AccountsPayableCredit` | accounts_payable_credit |