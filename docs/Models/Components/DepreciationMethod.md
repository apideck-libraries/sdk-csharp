# DepreciationMethod

The depreciation method of the assets, normalised across accounting systems: declining-balance variants (for example 150% or 200%) are all `declining_balance`, and the accounting system's own value is in `downstream_depreciation_method`. Set only when every asset recorded in the account uses the same method.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = DepreciationMethod.Other;

// Open enum: use .Of() to create instances from custom string values
var custom = DepreciationMethod.Of("custom_value");
```


## Values

| Name               | Value              |
| ------------------ | ------------------ |
| `Other`            | other              |
| `StraightLine`     | straight_line      |
| `DecliningBalance` | declining_balance  |
| `None`             | none               |