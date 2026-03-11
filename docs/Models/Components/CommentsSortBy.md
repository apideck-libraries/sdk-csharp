# CommentsSortBy

The field on which to sort the Comments

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = CommentsSortBy.CreatedAt;

// Open enum: use .Of() to create instances from custom string values
var custom = CommentsSortBy.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `CreatedAt` | created_at  |
| `UpdatedAt` | updated_at  |