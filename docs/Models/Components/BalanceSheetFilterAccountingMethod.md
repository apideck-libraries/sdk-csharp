# BalanceSheetFilterAccountingMethod

The accounting method used for the report: cash or accrual.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BalanceSheetFilterAccountingMethod.Cash;

// Open enum: use .Of() to create instances from custom string values
var custom = BalanceSheetFilterAccountingMethod.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Cash`    | cash      |
| `Accrual` | accrual   |