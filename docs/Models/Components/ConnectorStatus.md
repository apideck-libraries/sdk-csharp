# ConnectorStatus

Status of the connector. Connectors with status live or beta are callable.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ConnectorStatus.Live;

// Open enum: use .Of() to create instances from custom string values
var custom = ConnectorStatus.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Live`        | live          |
| `Beta`        | beta          |
| `EarlyAccess` | early-access  |
| `Development` | development   |
| `Considering` | considering   |