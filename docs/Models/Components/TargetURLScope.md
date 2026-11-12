# TargetURLScope

Where the vendor stores the webhook target URL. `app` means one URL per vendor developer app, which customers on Apideck's own credentials cannot configure. `tenant` means each customer's vendor account holds its own URL.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = TargetURLScope.App;

// Open enum: use .Of() to create instances from custom string values
var custom = TargetURLScope.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `App`    | app      |
| `Tenant` | tenant   |