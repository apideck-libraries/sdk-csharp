# Mode

Mode of the webhook support.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = Mode.Native;

// Open enum: use .Of() to create instances from custom string values
var custom = Mode.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Native`  | native    |
| `Virtual` | virtual   |
| `None`    | none      |