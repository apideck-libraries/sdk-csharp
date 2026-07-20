# ListVisibility

The visibility of the List. Which of these values a given connector can return depends on its native sharing model — see the connector-specific gotchas below for details.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ListVisibility.Private;

// Open enum: use .Of() to create instances from custom string values
var custom = ListVisibility.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Private` | private   |
| `Shared`  | shared    |
| `Public`  | public    |