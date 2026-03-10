# Visibility

The visibility of the job

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = Visibility.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = Visibility.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Draft`    | draft      |
| `Public`   | public     |
| `Internal` | internal   |