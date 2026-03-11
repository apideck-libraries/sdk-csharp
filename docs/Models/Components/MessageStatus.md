# MessageStatus

Status of the delivery of the message.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = MessageStatus.Accepted;

// Open enum: use .Of() to create instances from custom string values
var custom = MessageStatus.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Accepted`    | accepted      |
| `Scheduled`   | scheduled     |
| `Canceled`    | canceled      |
| `Queued`      | queued        |
| `Sending`     | sending       |
| `Sent`        | sent          |
| `Failed`      | failed        |
| `Delivered`   | delivered     |
| `Undelivered` | undelivered   |
| `Receiving`   | receiving     |
| `Received`    | received      |
| `Read`        | read          |