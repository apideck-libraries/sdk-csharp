# BankAccountType

Type of the bank account.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BankAccountType.Bank;

// Open enum: use .Of() to create instances from custom string values
var custom = BankAccountType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Bank`       | bank         |
| `CreditCard` | credit_card  |