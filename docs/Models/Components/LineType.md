# LineType

`account`: a ledger account. `unappropriated_result`: the result of earlier fiscal years not yet posted to an equity account, added by the connector. `unmapped`: a balance the accounting system reports without a ledger account.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = LineType.Account;

// Open enum: use .Of() to create instances from custom string values
var custom = LineType.Of("custom_value");
```


## Values

| Name                   | Value                  |
| ---------------------- | ---------------------- |
| `Account`              | account                |
| `UnappropriatedResult` | unappropriated_result  |
| `Unmapped`             | unmapped               |