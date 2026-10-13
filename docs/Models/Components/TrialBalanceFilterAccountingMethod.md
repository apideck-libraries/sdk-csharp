# TrialBalanceFilterAccountingMethod

The accounting method used for the report: cash or accrual.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = TrialBalanceFilterAccountingMethod.Cash;

// Open enum: use .Of() to create instances from custom string values
var custom = TrialBalanceFilterAccountingMethod.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Cash`    | cash      |
| `Accrual` | accrual   |