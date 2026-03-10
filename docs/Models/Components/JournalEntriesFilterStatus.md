# JournalEntriesFilterStatus

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = JournalEntriesFilterStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = JournalEntriesFilterStatus.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `Draft`           | draft             |
| `PendingApproval` | pending_approval  |
| `Approved`        | approved          |
| `Posted`          | posted            |
| `Voided`          | voided            |
| `Rejected`        | rejected          |
| `Deleted`         | deleted           |
| `Other`           | other             |