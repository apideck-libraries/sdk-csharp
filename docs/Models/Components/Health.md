# Health

Operational health status of the connection

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = Health.Revoked;

// Open enum: use .Of() to create instances from custom string values
var custom = Health.Of("custom_value");
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `Revoked`             | revoked               |
| `MissingSettings`     | missing_settings      |
| `NeedsConsent`        | needs_consent         |
| `PendingConfirmation` | pending_confirmation  |
| `NeedsAuth`           | needs_auth            |
| `PendingRefresh`      | pending_refresh       |
| `Ok`                  | ok                    |