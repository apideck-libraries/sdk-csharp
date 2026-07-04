# LedgerAccountsFilterStatus

Filter by account status. Supported only on a subset of connectors (e.g. NetSuite); connectors that do not support it reject `filter[status]` with a `400 UnsupportedFiltersError` — read the account's `status` field in the response and filter client-side instead. See the error's `supported_filters` or the connector's supported filters.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = LedgerAccountsFilterStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = LedgerAccountsFilterStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |