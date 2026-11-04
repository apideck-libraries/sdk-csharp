# CreditNoteUpdateInputCreditNoteStatus

Status of credit notes

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = CreditNoteUpdateInputCreditNoteStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = CreditNoteUpdateInputCreditNoteStatus.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Draft`         | draft           |
| `Authorised`    | authorised      |
| `Posted`        | posted          |
| `PartiallyPaid` | partially_paid  |
| `Paid`          | paid            |
| `Voided`        | voided          |
| `Deleted`       | deleted         |