# TicketsSortBy

The field on which to sort the Tickets

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = TicketsSortBy.CreatedAt;

// Open enum: use .Of() to create instances from custom string values
var custom = TicketsSortBy.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `CreatedAt` | created_at  |
| `UpdatedAt` | updated_at  |