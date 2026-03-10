# ActivityAttendeeStatus

Status of the attendee

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ActivityAttendeeStatus.Accepted;

// Open enum: use .Of() to create instances from custom string values
var custom = ActivityAttendeeStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Accepted`  | accepted    |
| `Tentative` | tentative   |
| `Declined`  | declined    |