# HolderType

Whether the holder is an individual or a business.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = HolderType.Consumer;

// Open enum: use .Of() to create instances from custom string values
var custom = HolderType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Consumer` | consumer   |
| `Business` | business   |