# ScheduleStatus

Current status of project schedule compared to plan

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ScheduleStatus.AheadOfSchedule;

// Open enum: use .Of() to create instances from custom string values
var custom = ScheduleStatus.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `AheadOfSchedule` | ahead_of_schedule |
| `OnSchedule`      | on_schedule       |
| `BehindSchedule`  | behind_schedule   |
| `CriticalDelay`   | critical_delay    |