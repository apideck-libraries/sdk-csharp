# Direction

The direction of the message.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = Direction.Inbound;

// Open enum: use .Of() to create instances from custom string values
var custom = Direction.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Inbound`       | inbound         |
| `OutboundApi`   | outbound-api    |
| `OutboundCall`  | outbound-call   |
| `OutboundReply` | outbound-reply  |
| `Unknown`       | unknown         |