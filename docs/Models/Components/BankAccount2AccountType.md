# BankAccount2AccountType

The type of bank account.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BankAccount2AccountType.BankAccount;

// Open enum: use .Of() to create instances from custom string values
var custom = BankAccount2AccountType.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `BankAccount` | bank_account  |
| `CreditCard`  | credit_card   |
| `Other`       | other         |