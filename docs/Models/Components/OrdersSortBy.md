# OrdersSortBy

The field on which to sort the Orders

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = OrdersSortBy.CreatedAt;

// Open enum: use .Of() to create instances from custom string values
var custom = OrdersSortBy.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `CreatedAt` | created_at  |
| `UpdatedAt` | updated_at  |
| `Name`      | name        |