# ProjectUpdateInputPriority

Priority level of the project

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ProjectUpdateInputPriority.Low;

// Open enum: use .Of() to create instances from custom string values
var custom = ProjectUpdateInputPriority.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Low`      | low        |
| `Medium`   | medium     |
| `High`     | high       |
| `Critical` | critical   |