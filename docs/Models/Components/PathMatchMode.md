# PathMatchMode

How the path filter is matched. CONTAINS matches the path anywhere; STARTS_WITH / ENDS_WITH anchor the match; EXACT requires the whole path to match. Only applied when path is set.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = PathMatchMode.Contains;

// Open enum: use .Of() to create instances from custom string values
var custom = PathMatchMode.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Contains`   | CONTAINS     |
| `StartsWith` | STARTS_WITH  |
| `EndsWith`   | ENDS_WITH    |
| `Exact`      | EXACT        |