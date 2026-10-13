# FiscalPeriodStatus

Whether transactions can be posted into the period. `open`: postings are accepted on at least the last day of the period; a lock date inside the period still rejects earlier dates (see `locked_through`). `locked`: posting is blocked for some users or transaction types only, for example everyone except advisers or administrators. `closed`: posting is blocked for all users until the period or year is reopened. `future`: the accounting system reports the period as not yet opened. Null or absent means the connector does not expose the period's status.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = FiscalPeriodStatus.Open;

// Open enum: use .Of() to create instances from custom string values
var custom = FiscalPeriodStatus.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Open`   | open     |
| `Locked` | locked   |
| `Closed` | closed   |
| `Future` | future   |