# Priority

Priority level of the project

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = Priority.Low;

// Open enum: use .Of() to create instances from custom string values
var custom = Priority.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Low`      | low        |
| `Medium`   | medium     |
| `High`     | high       |
| `Critical` | critical   |