# OpportunitiesSortBy

The field on which to sort the Opportunities

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = OpportunitiesSortBy.CreatedAt;

// Open enum: use .Of() to create instances from custom string values
var custom = OpportunitiesSortBy.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `CreatedAt`      | created_at       |
| `UpdatedAt`      | updated_at       |
| `Title`          | title            |
| `WinProbability` | win_probability  |
| `MonetaryAmount` | monetary_amount  |
| `Status`         | status           |