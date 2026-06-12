# JournalEntriesFilterScope

Connector-specific scope hint that controls which downstream source backs the read. On Xero, `manual` reads from `ManualJournals` (free in every tier), while `system` reads from `Journals` (the full general ledger view including manual journal postings, paid post 2026-03-02). Omitting the filter is equivalent to `system` and preserves the legacy default. Only honored on connectors where the distinction is exposed; ignored elsewhere.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = JournalEntriesFilterScope.Manual;

// Open enum: use .Of() to create instances from custom string values
var custom = JournalEntriesFilterScope.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Manual` | manual   |
| `System` | system   |