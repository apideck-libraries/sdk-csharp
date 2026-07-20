# ListType

Whether the List is static (a fixed set of records) or dynamic (a saved segment that is automatically kept up to date based on filter criteria).

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ListType.Static;

// Open enum: use .Of() to create instances from custom string values
var custom = ListType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Static`  | static    |
| `Dynamic` | dynamic   |