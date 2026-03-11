# ManagedVia

How the subscription is managed in the downstream.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ManagedVia.Manual;

// Open enum: use .Of() to create instances from custom string values
var custom = ManagedVia.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Manual` | manual   |
| `Api`    | api      |