# PaymentStatus

Status of payment

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = PaymentStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = PaymentStatus.Of("custom_value");
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