# EmployeesFilterEmploymentStatus

Employment status to filter on

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = EmployeesFilterEmploymentStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = EmployeesFilterEmploymentStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Active`     | active       |
| `Inactive`   | inactive     |
| `Terminated` | terminated   |
| `Other`      | other        |