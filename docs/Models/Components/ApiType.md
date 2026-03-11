# ApiType

Indicates whether the API is a Unified API. If unified_api is false, the API is a Platform API.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ApiType.Platform;

// Open enum: use .Of() to create instances from custom string values
var custom = ApiType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Platform` | platform   |
| `Unified`  | unified    |