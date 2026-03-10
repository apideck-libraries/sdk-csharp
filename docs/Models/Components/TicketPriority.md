# TicketPriority

Priority of the ticket

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = TicketPriority.Low;

// Open enum: use .Of() to create instances from custom string values
var custom = TicketPriority.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Low`    | low      |
| `Normal` | normal   |
| `High`   | high     |
| `Urgent` | urgent   |