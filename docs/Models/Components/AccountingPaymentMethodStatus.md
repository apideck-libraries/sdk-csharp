# AccountingPaymentMethodStatus

The status of the payment method.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = AccountingPaymentMethodStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingPaymentMethodStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |