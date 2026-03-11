# RebillStatus

Status of the rebilling process for this line item.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = RebillStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = RebillStatus.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Pending` | pending   |
| `Billed`  | billed    |
| `Voided`  | voided    |