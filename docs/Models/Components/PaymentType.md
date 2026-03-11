# PaymentType

Type of payment

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = PaymentType.AccountsReceivable;

// Open enum: use .Of() to create instances from custom string values
var custom = PaymentType.Of("custom_value");
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `AccountsReceivable`            | accounts_receivable             |
| `AccountsPayable`               | accounts_payable                |
| `AccountsReceivableCredit`      | accounts_receivable_credit      |
| `AccountsPayableCredit`         | accounts_payable_credit         |
| `AccountsReceivableOverpayment` | accounts_receivable_overpayment |
| `AccountsPayableOverpayment`    | accounts_payable_overpayment    |
| `AccountsReceivablePrepayment`  | accounts_receivable_prepayment  |
| `AccountsPayablePrepayment`     | accounts_payable_prepayment     |