# ApplicationStatus

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ApplicationStatus.Open;

// Open enum: use .Of() to create instances from custom string values
var custom = ApplicationStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Open`      | open        |
| `Rejected`  | rejected    |
| `Hired`     | hired       |
| `Converted` | converted   |
| `Other`     | other       |