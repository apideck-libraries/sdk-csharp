# PeriodType

The type of period to include in the resource: month, quarter, year.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = PeriodType.Month;

// Open enum: use .Of() to create instances from custom string values
var custom = PeriodType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Month`   | month     |
| `Quarter` | quarter   |
| `Year`    | year      |