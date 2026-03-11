# ContactsSortBy

The field on which to sort the Contacts

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ContactsSortBy.CreatedAt;

// Open enum: use .Of() to create instances from custom string values
var custom = ContactsSortBy.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `CreatedAt` | created_at  |
| `UpdatedAt` | updated_at  |
| `Name`      | name        |
| `FirstName` | first_name  |
| `LastName`  | last_name   |
| `Email`     | email       |