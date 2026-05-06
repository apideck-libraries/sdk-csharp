# ConnectionHealth

The operational health status of the connection

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ConnectionHealth.Ok;

// Open enum: use .Of() to create instances from custom string values
var custom = ConnectionHealth.Of("custom_value");
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `Ok`                  | ok                    |
| `PendingRefresh`      | pending_refresh       |
| `NeedsAuth`           | needs_auth            |
| `PendingConfirmation` | pending_confirmation  |
| `NeedsConsent`        | needs_consent         |
| `Revoked`             | revoked               |
| `MissingSettings`     | missing_settings      |