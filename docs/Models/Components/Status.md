# Status

The status of the webhook.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = Status.Enabled;

// Open enum: use .Of() to create instances from custom string values
var custom = Status.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Enabled`  | enabled    |
| `Disabled` | disabled   |