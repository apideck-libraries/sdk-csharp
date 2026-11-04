# ProjectUpdateInputProjectPhase

Current phase of the project lifecycle

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ProjectUpdateInputProjectPhase.Initiation;

// Open enum: use .Of() to create instances from custom string values
var custom = ProjectUpdateInputProjectPhase.Of("custom_value");
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