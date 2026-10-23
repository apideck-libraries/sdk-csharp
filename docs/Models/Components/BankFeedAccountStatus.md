# BankFeedAccountStatus

Whether the data consumer may see this account. `revoked` hides it from the consumer without deleting it; `active` restores it. Unrelated to `feed_status`. Only connectors that list it support it; others ignore the field, so setting it there changes nothing.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BankFeedAccountStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = BankFeedAccountStatus.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Active`  | active    |
| `Revoked` | revoked   |