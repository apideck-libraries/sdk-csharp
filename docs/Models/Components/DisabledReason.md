# DisabledReason

Indicates why the webhook has been disabled. `retry_limit`: webhook reached its retry limit. `usage_limit`: account is over its usage limit. `delivery_url_validation_failed`: delivery URL failed validation during webhook creation or update.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = DisabledReason.None;

// Open enum: use .Of() to create instances from custom string values
var custom = DisabledReason.Of("custom_value");
```


## Values

| Name                           | Value                          |
| ------------------------------ | ------------------------------ |
| `None`                         | none                           |
| `RetryLimit`                   | retry_limit                    |
| `UsageLimit`                   | usage_limit                    |
| `DeliveryUrlValidationFailed`  | delivery_url_validation_failed |