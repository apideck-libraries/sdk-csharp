# RefundStatus

Status of refund. Maps to: QBO (limited status), NetSuite CashRefund status, Sage Intacct state (draft/posted/voided), Zoho Books vis_state.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = RefundStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = RefundStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Draft`      | draft        |
| `Authorised` | authorised   |
| `Posted`     | posted       |
| `Paid`       | paid         |
| `Voided`     | voided       |
| `Deleted`    | deleted      |