# BankAccountsFilterAccountType

Filter by account type

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BankAccountsFilterAccountType.Checking;

// Open enum: use .Of() to create instances from custom string values
var custom = BankAccountsFilterAccountType.Of("custom_value");
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