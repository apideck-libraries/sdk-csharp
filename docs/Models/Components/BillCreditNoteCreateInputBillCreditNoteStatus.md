# BillCreditNoteCreateInputBillCreditNoteStatus

Status of bill credit notes

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BillCreditNoteCreateInputBillCreditNoteStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = BillCreditNoteCreateInputBillCreditNoteStatus.Of("custom_value");
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