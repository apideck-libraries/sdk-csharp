# CustomFieldFinderType

The declared data type of the custom field. Only returned by connectors that can read the field's definition; omitted otherwise.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = CustomFieldFinderType.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = CustomFieldFinderType.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Text`           | text             |
| `Checkbox`       | checkbox         |
| `Tel`            | tel              |
| `Email`          | email            |
| `Url`            | url              |
| `Textarea`       | textarea         |
| `Select`         | select           |
| `FilteredSelect` | filtered-select  |
| `MultiSelect`    | multi-select     |
| `Datetime`       | datetime         |
| `Date`           | date             |
| `Time`           | time             |
| `Number`         | number           |
| `Password`       | password         |