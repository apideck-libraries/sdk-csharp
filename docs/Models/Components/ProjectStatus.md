# ProjectStatus

Status of projects to filter by

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ProjectStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = ProjectStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Active`     | active       |
| `Completed`  | completed    |
| `OnHold`     | on_hold      |
| `Cancelled`  | cancelled    |
| `Draft`      | draft        |
| `InProgress` | in_progress  |
| `Approved`   | approved     |
| `Other`      | other        |