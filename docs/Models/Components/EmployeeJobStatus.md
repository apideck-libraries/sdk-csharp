# EmployeeJobStatus

Indicates the status of the job.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = EmployeeJobStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = EmployeeJobStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |
| `Other`    | other      |