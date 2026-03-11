# ProjectPhase

Current phase of the project lifecycle

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ProjectPhase.Initiation;

// Open enum: use .Of() to create instances from custom string values
var custom = ProjectPhase.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Initiation` | initiation   |
| `Planning`   | planning     |
| `Execution`  | execution    |
| `Monitoring` | monitoring   |
| `Closure`    | closure      |
| `Other`      | other        |