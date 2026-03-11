# Unit

The window unit for the rate.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = Unit.Second;

// Open enum: use .Of() to create instances from custom string values
var custom = Unit.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Second` | second   |
| `Minute` | minute   |
| `Hour`   | hour     |
| `Day`    | day      |