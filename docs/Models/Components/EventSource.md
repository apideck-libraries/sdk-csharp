# EventSource

Unify event source

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = EventSource.Native;

// Open enum: use .Of() to create instances from custom string values
var custom = EventSource.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Native`  | native    |
| `Virtual` | virtual   |