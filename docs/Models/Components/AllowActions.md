# AllowActions

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = AllowActions.Delete;

// Open enum: use .Of() to create instances from custom string values
var custom = AllowActions.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Delete`      | delete        |
| `Disconnect`  | disconnect    |
| `Reauthorize` | reauthorize   |
| `Disable`     | disable       |