# EmailType

Email type

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = EmailType.Primary;

// Open enum: use .Of() to create instances from custom string values
var custom = EmailType.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Primary`   | primary     |
| `Secondary` | secondary   |
| `Work`      | work        |
| `Personal`  | personal    |
| `Billing`   | billing     |
| `Other`     | other       |