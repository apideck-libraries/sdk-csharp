# EmploymentStatus

The employment status of the employee, indicating whether they are currently employed, inactive, terminated, or in another status.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = EmploymentStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = EmploymentStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Active`     | active       |
| `Inactive`   | inactive     |
| `Terminated` | terminated   |
| `Other`      | other        |