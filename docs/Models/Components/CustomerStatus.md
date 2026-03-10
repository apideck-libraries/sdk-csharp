# CustomerStatus

The current status of the customer

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = CustomerStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = CustomerStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Archived` | archived   |