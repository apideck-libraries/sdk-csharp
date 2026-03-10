# BankFeedStatementTransactionType

Type of transaction.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BankFeedStatementTransactionType.Credit;

// Open enum: use .Of() to create instances from custom string values
var custom = BankFeedStatementTransactionType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Credit`   | credit     |
| `Debit`    | debit      |
| `Deposit`  | deposit    |
| `Transfer` | transfer   |
| `Payment`  | payment    |
| `Other`    | other      |