# EmployeeStatus

The status of the employee.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = EmployeeStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = EmployeeStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Active`     | active       |
| `Inactive`   | inactive     |
| `Terminated` | terminated   |