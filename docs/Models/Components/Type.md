# Type

The type of address.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = Type.Primary;

// Open enum: use .Of() to create instances from custom string values
var custom = Type.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Primary`   | primary     |
| `Secondary` | secondary   |
| `Home`      | home        |
| `Office`    | office      |
| `Shipping`  | shipping    |
| `Billing`   | billing     |
| `Work`      | work        |
| `Other`     | other       |