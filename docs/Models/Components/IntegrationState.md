# IntegrationState

The current state of the Integration.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = IntegrationState.Disabled;

// Open enum: use .Of() to create instances from custom string values
var custom = IntegrationState.Of("custom_value");
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `Disabled`           | disabled             |
| `NeedsConfiguration` | needs_configuration  |
| `Configured`         | configured           |