# SubscriptionLevel

Received events are scoped to connection or across integration.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = SubscriptionLevel.Connection;

// Open enum: use .Of() to create instances from custom string values
var custom = SubscriptionLevel.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Connection`  | connection    |
| `Integration` | integration   |