# TimeOffRequestStatusStatus

The status of the time off request.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = TimeOffRequestStatusStatus.Requested;

// Open enum: use .Of() to create instances from custom string values
var custom = TimeOffRequestStatusStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Requested` | requested   |
| `Approved`  | approved    |
| `Declined`  | declined    |
| `Cancelled` | cancelled   |
| `Deleted`   | deleted     |
| `Other`     | other       |