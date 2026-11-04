# ProjectUpdateInputScheduleStatus

Current status of project schedule compared to plan

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ProjectUpdateInputScheduleStatus.AheadOfSchedule;

// Open enum: use .Of() to create instances from custom string values
var custom = ProjectUpdateInputScheduleStatus.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `AheadOfSchedule` | ahead_of_schedule |
| `OnSchedule`      | on_schedule       |
| `BehindSchedule`  | behind_schedule   |
| `CriticalDelay`   | critical_delay    |