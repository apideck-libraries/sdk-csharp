# EcommerceOrderPaymentStatus

Current payment status of the order.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = EcommerceOrderPaymentStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = EcommerceOrderPaymentStatus.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `Pending`           | pending             |
| `Authorized`        | authorized          |
| `Paid`              | paid                |
| `Partial`           | partial             |
| `Refunded`          | refunded            |
| `Voided`            | voided              |
| `Unknown`           | unknown             |
| `PartiallyRefunded` | partially_refunded  |