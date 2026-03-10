# ApplicantType

The type of website

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ApplicantType.Primary;

// Open enum: use .Of() to create instances from custom string values
var custom = ApplicantType.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Primary`   | primary     |
| `Secondary` | secondary   |
| `Work`      | work        |
| `Personal`  | personal    |
| `Other`     | other       |