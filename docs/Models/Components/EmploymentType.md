# EmploymentType

The type of employment relationship the employee has with the organization.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = EmploymentType.Contractor;

// Open enum: use .Of() to create instances from custom string values
var custom = EmploymentType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Contractor` | contractor   |
| `Employee`   | employee     |
| `Freelance`  | freelance    |
| `Temp`       | temp         |
| `Internship` | internship   |
| `Other`      | other        |