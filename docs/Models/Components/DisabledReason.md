# DisabledReason

Indicates why the webhook has been disabled. `retry_limit`: webhook reached its retry limit. `usage_limit`: account is over its usage limit. `delivery_url_validation_failed`: delivery URL failed validation during webhook creation or update.


## Values

| Name                           | Value                          |
| ------------------------------ | ------------------------------ |
| `None`                         | none                           |
| `RetryLimit`                   | retry_limit                    |
| `UsageLimit`                   | usage_limit                    |
| `DeliveryUrlValidationFailed`  | delivery_url_validation_failed |