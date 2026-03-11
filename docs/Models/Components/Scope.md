# Scope

The scope of the shared link.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = Scope.Public;

// Open enum: use .Of() to create instances from custom string values
var custom = Scope.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Public`  | public    |
| `Company` | company   |