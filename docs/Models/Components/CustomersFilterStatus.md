# CustomersFilterStatus

Status of customer to filter on

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = CustomersFilterStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = CustomersFilterStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | active     |
| `Inactive` | inactive   |
| `Archived` | archived   |
| `All`      | all        |