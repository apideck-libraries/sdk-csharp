# FiscalPeriodPeriodType

Whether this record is a posting period, or a quarter or year that groups posting periods.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = FiscalPeriodPeriodType.Period;

// Open enum: use .Of() to create instances from custom string values
var custom = FiscalPeriodPeriodType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Period`  | period    |
| `Quarter` | quarter   |
| `Year`    | year      |