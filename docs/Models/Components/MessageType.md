# MessageType

Set to sms for SMS messages and mms for MMS messages.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = MessageType.Sms;

// Open enum: use .Of() to create instances from custom string values
var custom = MessageType.Of("custom_value");
```


## Values

| Name  | Value |
| ----- | ----- |
| `Sms` | sms   |
| `Mms` | mms   |