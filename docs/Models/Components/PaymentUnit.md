# PaymentUnit

Unit of measurement for employee compensation.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = PaymentUnit.Hour;

// Open enum: use .Of() to create instances from custom string values
var custom = PaymentUnit.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Hour`     | hour       |
| `Week`     | week       |
| `Month`    | month      |
| `Year`     | year       |
| `Paycheck` | paycheck   |
| `Other`    | other      |