# FeedStatus

Current status of the bank feed.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = FeedStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = FeedStatus.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Pending`  | pending    |
| `Rejected` | rejected   |