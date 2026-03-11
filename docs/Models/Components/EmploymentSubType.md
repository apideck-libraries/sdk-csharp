# EmploymentSubType

The work schedule of the employee.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = EmploymentSubType.FullTime;

// Open enum: use .Of() to create instances from custom string values
var custom = EmploymentSubType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `FullTime`     | full_time      |
| `PartTime`     | part_time      |
| `Hourly`       | hourly         |
| `Other`        | other          |
| `NotSpecified` | not_specified  |