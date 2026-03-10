# QuoteStatus

Quote status

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = QuoteStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = QuoteStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Draft`     | draft       |
| `Sent`      | sent        |
| `Accepted`  | accepted    |
| `Rejected`  | rejected    |
| `Expired`   | expired     |
| `Converted` | converted   |
| `Void`      | void        |
| `Deleted`   | deleted     |