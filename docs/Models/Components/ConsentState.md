# ConsentState

The current consent state of the connection

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ConsentState.Implicit;

// Open enum: use .Of() to create instances from custom string values
var custom = ConsentState.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `Implicit`          | implicit            |
| `Pending`           | pending             |
| `Granted`           | granted             |
| `Denied`            | denied              |
| `Revoked`           | revoked             |
| `RequiresReconsent` | requires_reconsent  |