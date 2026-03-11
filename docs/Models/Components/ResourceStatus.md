# ResourceStatus

Status of the resource. Resources with status live or beta are callable.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ResourceStatus.Live;

// Open enum: use .Of() to create instances from custom string values
var custom = ResourceStatus.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Live`        | live          |
| `Beta`        | beta          |
| `Development` | development   |
| `Upcoming`    | upcoming      |
| `Considering` | considering   |