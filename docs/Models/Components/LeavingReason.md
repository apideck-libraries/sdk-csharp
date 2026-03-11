# LeavingReason

The reason because the employment ended.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = LeavingReason.Dismissed;

// Open enum: use .Of() to create instances from custom string values
var custom = LeavingReason.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Dismissed`  | dismissed    |
| `Resigned`   | resigned     |
| `Redundancy` | redundancy   |
| `Retired`    | retired      |
| `Other`      | other        |