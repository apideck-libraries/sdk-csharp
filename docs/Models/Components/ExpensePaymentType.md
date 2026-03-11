# ExpensePaymentType

The type of payment for the expense.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ExpensePaymentType.Cash;

// Open enum: use .Of() to create instances from custom string values
var custom = ExpensePaymentType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Cash`       | cash         |
| `Check`      | check        |
| `CreditCard` | credit_card  |
| `Other`      | other        |