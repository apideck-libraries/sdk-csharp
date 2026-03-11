# TimeOffRequestStatus

Time off request status to filter on

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = TimeOffRequestStatus.Requested;

// Open enum: use .Of() to create instances from custom string values
var custom = TimeOffRequestStatus.Of("custom_value");
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