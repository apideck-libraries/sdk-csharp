# Units

The unit of time off requested. Possible values include: `hours`, `days`, or `other`.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = Units.Days;

// Open enum: use .Of() to create instances from custom string values
var custom = Units.Of("custom_value");
```


## Values

| Name    | Value   |
| ------- | ------- |
| `Days`  | days    |
| `Hours` | hours   |
| `Other` | other   |