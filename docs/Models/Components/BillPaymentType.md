# BillPaymentType

Type of payment

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BillPaymentType.AccountsPayableCredit;

// Open enum: use .Of() to create instances from custom string values
var custom = BillPaymentType.Of("custom_value");
```


## Values

| Name                         | Value                        |
| ---------------------------- | ---------------------------- |
| `AccountsPayableCredit`      | accounts_payable_credit      |
| `AccountsPayableOverpayment` | accounts_payable_overpayment |
| `AccountsPayablePrepayment`  | accounts_payable_prepayment  |
| `AccountsPayable`            | accounts_payable             |