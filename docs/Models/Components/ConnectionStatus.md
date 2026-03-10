# ConnectionStatus

Status of the connection.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ConnectionStatus.Live;

// Open enum: use .Of() to create instances from custom string values
var custom = ConnectionStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Live`      | live        |
| `Upcoming`  | upcoming    |
| `Requested` | requested   |