# LedgerAccountType

The type of account.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = LedgerAccountType.AccountsPayable;

// Open enum: use .Of() to create instances from custom string values
var custom = LedgerAccountType.Of("custom_value");
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `AccountsPayable`     | accounts_payable      |
| `AccountsReceivable`  | accounts_receivable   |
| `Balancesheet`        | balancesheet          |
| `Bank`                | bank                  |
| `CostsOfSales`        | costs_of_sales        |
| `CreditCard`          | credit_card           |
| `CurrentAsset`        | current_asset         |
| `CurrentLiability`    | current_liability     |
| `Equity`              | equity                |
| `Expense`             | expense               |
| `FixedAsset`          | fixed_asset           |
| `NonCurrentAsset`     | non_current_asset     |
| `NonCurrentLiability` | non_current_liability |
| `OtherAsset`          | other_asset           |
| `OtherExpense`        | other_expense         |
| `OtherIncome`         | other_income          |
| `OtherLiability`      | other_liability       |
| `Revenue`             | revenue               |
| `Sales`               | sales                 |
| `Other`               | other                 |