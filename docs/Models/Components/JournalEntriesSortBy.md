# JournalEntriesSortBy

The field on which to sort the Journal Entries.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = JournalEntriesSortBy.CreatedAt;

// Open enum: use .Of() to create instances from custom string values
var custom = JournalEntriesSortBy.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `CreatedAt` | created_at  |
| `UpdatedAt` | updated_at  |