# ConnectionState

[Connection state flow](#section/Connection-state)

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ConnectionState.Available;

// Open enum: use .Of() to create instances from custom string values
var custom = ConnectionState.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Available`  | available    |
| `Callable`   | callable     |
| `Added`      | added        |
| `Authorized` | authorized   |
| `Invalid`    | invalid      |