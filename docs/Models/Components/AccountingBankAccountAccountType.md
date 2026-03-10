# AccountingBankAccountAccountType

The type of bank account

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = AccountingBankAccountAccountType.Checking;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingBankAccountAccountType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Checking`     | checking       |
| `Savings`      | savings        |
| `CreditCard`   | credit_card    |
| `MoneyMarket`  | money_market   |
| `LineOfCredit` | line_of_credit |
| `Other`        | other          |
| `Cash`         | cash           |