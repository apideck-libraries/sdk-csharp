# CreditOrDebit

Whether the amount is a credit or debit.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = CreditOrDebit.Credit;

// Open enum: use .Of() to create instances from custom string values
var custom = CreditOrDebit.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Credit` | credit   |
| `Debit`  | debit    |