# FlsaStatus

The FLSA status for this compensation.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = FlsaStatus.Exempt;

// Open enum: use .Of() to create instances from custom string values
var custom = FlsaStatus.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `Exempt`            | exempt              |
| `SalariedNonexempt` | salaried-nonexempt  |
| `Nonexempt`         | nonexempt           |
| `Owner`             | owner               |
| `Other`             | other               |