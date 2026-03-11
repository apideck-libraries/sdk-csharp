# PaymentFrequency

Frequency of employee compensation.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = PaymentFrequency.Weekly;

// Open enum: use .Of() to create instances from custom string values
var custom = PaymentFrequency.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Weekly`   | weekly     |
| `Biweekly` | biweekly   |
| `Monthly`  | monthly    |
| `ProRata`  | pro-rata   |
| `Other`    | other      |