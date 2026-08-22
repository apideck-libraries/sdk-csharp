# AccountingPaymentMethodType

The type of payment method.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = AccountingPaymentMethodType.Cash;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingPaymentMethodType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Cash`         | cash           |
| `Check`        | check          |
| `CreditCard`   | credit_card    |
| `DebitCard`    | debit_card     |
| `BankTransfer` | bank_transfer  |
| `Electronic`   | electronic     |
| `Other`        | other          |
| `Unknown`      | unknown        |