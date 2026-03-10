# ProjectProjectStatus

Current status of the project

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ProjectProjectStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = ProjectProjectStatus.Of("custom_value");
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