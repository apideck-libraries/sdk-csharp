# FileType

The type of resource. Could be file, folder or url

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = FileType.File;

// Open enum: use .Of() to create instances from custom string values
var custom = FileType.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `File`   | file     |
| `Folder` | folder   |
| `Url`    | url      |