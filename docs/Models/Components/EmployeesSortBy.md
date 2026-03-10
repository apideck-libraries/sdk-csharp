# EmployeesSortBy

The field on which to sort the Employees

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = EmployeesSortBy.FirstName;

// Open enum: use .Of() to create instances from custom string values
var custom = EmployeesSortBy.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `FirstName` | first_name  |
| `LastName`  | last_name   |
| `CreatedAt` | created_at  |
| `UpdatedAt` | updated_at  |