# ApiStatus

Status of the API. APIs with status live or beta are callable.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ApiStatus.Live;

// Open enum: use .Of() to create instances from custom string values
var custom = ApiStatus.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Live`        | live          |
| `Beta`        | beta          |
| `Development` | development   |
| `Considering` | considering   |