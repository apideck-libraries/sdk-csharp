# CustomObjectSchemaType

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = CustomObjectSchemaType.String;

// Open enum: use .Of() to create instances from custom string values
var custom = CustomObjectSchemaType.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `String`      | string        |
| `Number`      | number        |
| `Integer`     | integer       |
| `Boolean`     | boolean       |
| `Date`        | date          |
| `Datetime`    | datetime      |
| `Currency`    | currency      |
| `Email`       | email         |
| `Phone`       | phone         |
| `Reference`   | reference     |
| `Select`      | select        |
| `Multiselect` | multiselect   |