# BillCreateInputAmortizationType

Type of amortization

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BillCreateInputAmortizationType.Manual;

// Open enum: use .Of() to create instances from custom string values
var custom = BillCreateInputAmortizationType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Manual`   | manual     |
| `Receipt`  | receipt    |
| `Schedule` | schedule   |
| `Other`    | other      |