# PaymentsFilterPaymentStatus

Filter by payment status

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = PaymentsFilterPaymentStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = PaymentsFilterPaymentStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Draft`      | draft        |
| `Authorised` | authorised   |
| `Rejected`   | rejected     |
| `Paid`       | paid         |
| `Voided`     | voided       |
| `Deleted`    | deleted      |